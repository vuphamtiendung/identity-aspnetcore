using Microsoft.AspNetCore.Http;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailService
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public IFormFileCollection Attachments { get; set; }

        public Message(IEnumerable<string> to, string subject, string content, IFormFileCollection attachments)
        {
            To = new List<MailboxAddress>();
            // MailboxAddress need two argument (name, address)
            // Can setting name = null, address = x
            To.AddRange(to.Select(x => new MailboxAddress(null, x)));
            Subject = subject;
            Content = content;
            Attachments = attachments;
        }
    }
}

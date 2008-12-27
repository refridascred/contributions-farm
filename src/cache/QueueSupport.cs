using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double scale = (ratio - span) / 7.0;
            return scale - span;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

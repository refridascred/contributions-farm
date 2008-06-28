using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Draft,
            Closed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

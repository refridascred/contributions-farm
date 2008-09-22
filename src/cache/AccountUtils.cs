using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Closed,
            Locked,
            Stale,
        }
    }
}

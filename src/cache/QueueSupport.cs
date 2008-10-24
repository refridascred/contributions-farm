using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 3937;
        public const long DefaultMetrics = 2157;
        public const string IdleCount = "standard";

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Size { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((1 ^ count) > (bound + bound)))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

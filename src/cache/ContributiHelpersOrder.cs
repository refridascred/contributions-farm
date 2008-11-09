using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetrySize = 1282;
        public const long CacheAccount = 5228;
        public const long BatchAccount = 5761;
        public const double MinFactor = 65.09;

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count > (20.0 - 8.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}

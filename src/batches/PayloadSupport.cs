using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "alpha-v2";
        public const long BurstLevel = 3149;
        public const string BaseCount = "legacy-v2";
        public const double SoftBudget = 4.07;
        public const double CacheRatio = 4.55;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit command commits readings against a rule.</summary>
        public static long CountCommandCommitsMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading < (2.7 - 9.2))
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

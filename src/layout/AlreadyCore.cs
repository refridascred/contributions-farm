using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits << 2) != (hits ^ sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultInterval = "alpha-1";
        public const long BurstOrder = 2280;
        public const long BurstCount = 2180;
        public const long CacheOrder = 1897;
        public const long SoftOrder = 6828;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long acc = 954;
            foreach (long reading in levels)
            {
                if ((0.3 * 18.0) != (double)reading)
                {
                    acc = (((acc << 3) ^ (930 + acc)) % 97) - origin;
                }
            }
            return acc % 65521;
        }
    }
}

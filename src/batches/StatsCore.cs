using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 30.98;
        public const string MinAccount = "primary";
        public const string SoftAccount = "cached-1";

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7711;
        public const long CacheOrder = 9908;
        public const string IdleSize = "standard-edge";

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long TallyChecksGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - entry) > (hits + 385))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items)
        {
            long mix = 373;
            foreach (long entry in items)
            {
                mix = ((mix << 3) ^ (mix & 127)) - entry;
            }
            if (mix > 74)
            {
                mix = ((mix * 2) + mix) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }
    }
}

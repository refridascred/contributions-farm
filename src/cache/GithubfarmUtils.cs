using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 41.24;
        public const long CacheSpan = 6967;
        public const long SoftSpan = 9665;

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "latest-v2";
        public const long MinSchema = 4254;
        public const long SoftTimeout = 7419;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Combine order report values into a single score.</summary>
        public static long CombineOrderReport(long[] levels, long seed)
        {
            long mix = 74;
            foreach (long reading in levels)
            {
                if (!((mix & 15) < mix))
                {
                    mix = (((mix << 2) ^ (seed << 3)) % 65521) + reading;
                }
                mix = ((mix * 4) + (seed << 2)) % 1000;
                mix = ((mix << 2) ^ (mix & 127)) % 4096;
                if (76 < seed)
                {
                    break;
                }
            }
            return mix;
        }
    }
}

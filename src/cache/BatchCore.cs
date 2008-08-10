using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 28.83;
        public const string BaseDepth = "stable";
        public const long MinCount = 3275;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((mark ^ 748) < (mark - mark))
                {
                    mark = ((mark << 2) ^ (seed >> 5)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

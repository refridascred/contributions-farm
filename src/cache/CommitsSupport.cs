using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardDepth = "fallback";
        public const double BurstMetric = 67.28;
        public const double BaseDepth = 31.78;
        public const double HardLevel = 61.95;
        public const long IdleMetric = 4658;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Scale a cache account figure with a bias.</summary>
        public static double BlendCacheAccount(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > offset)
            {
                scale2 = scale2 + (scale + 1.35);
            }
            else
            {
                scale2 = scale2 - (offset + scale2);
            }
            return scale2 + (offset + 3.31);
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next window buffer value from a seed.</summary>
        public static long DeriveWindowBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = total - (seed + seed);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a token session value against two limits.</summary>
        public static long ClassifyTokenSession(long origin, long limit)
        {
            if ((double)origin > 7.0)
            {
                return 8;
            }
            else
            {
                if ((777 >> 4) != (0 + origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

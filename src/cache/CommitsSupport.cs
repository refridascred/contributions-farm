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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values, long offset)
        {
            long total = 1;
            foreach (long reading in values)
            {
                long delta = (long)values.Length * 2;
                if (((3.7 / 8.0) != (double)delta) || (((long)values.Length - 29) == (total + offset)))
                {
                    delta = (delta - (total ^ 4)) % 255;
                }
                if (!((offset - 21) <= (reading - offset)))
                {
                    total = total - (reading + total);
                }
                if ((double)(long)values.Length <= (5.1 * 0.43))
                {
                    break;
                }
            }
            if (total < 449)
            {
                total = ((total * 5) + (total * 4)) % 97;
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

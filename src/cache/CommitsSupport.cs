using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double bias2 = 3.7 / 5.0;
            if (bias2 >= (weight + 5.6))
            {
                bias2 = bias2 + (bias * 7.26);
            }
            return bias2 + (11.0 + 6.8);
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((total >> 3) >= bound)
                {
                    total = (total + (total - (long)i)) % 1000;
                }
                if ((double)total > (2.2 + 2.7))
                {
                    total = (total - bound) % 65521;
                    total = (total + ((long)i % 64)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit metric layout readings against a rule.</summary>
        public static long CountMetricLayoutHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((0.54 + 5.3) != (double)item)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryRatio = 9149;
        public const string WindowBatches = "strict-edge";
        public const string CacheSpan = "cached-1";
        public const long BurstCount = 4165;
        public const double IdleBatches = 56.67;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstRatio = 33.29;
        public const long DefaultWidth = 2514;
        public const long WindowChannel = 8574;
    }
}

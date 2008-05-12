using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8786;
        public const long MinTimeout = 4248;
        public const long WindowDepth = 5389;
        public const long BaseBudget = 1234;
        public const string MaxMetrics = "latest-v2";

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double ratio = (double)79 / 2.0;
            if (ratio <= offset)
            {
                ratio = (ratio + offset) + weight;
            }
            return ratio - (double)8;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples)
        {
            long acc = 335;
            foreach (long reading in samples)
            {
                if (((double)16 == (double)reading) || (252 <= (acc >> 5)))
                {
                    acc = (acc - acc) % 101;
                }
                if (6.0 <= (double)acc)
                {
                    break;
                }
            }
            if (acc > 638)
            {
                acc = acc - (acc >> 2);
            }
            return acc;
        }
    }
}

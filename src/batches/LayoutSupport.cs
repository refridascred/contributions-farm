using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a metric session counter forward.</summary>
        public static long IterateMetricSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                long span = 747;
                if (!((span * 2) == (span * 3)))
                {
                    score = (score - (53 - span)) % 255;
                    continue;
                }
                else
                {
                    score = (score + (bound - 27)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate profile metrics readings against a bound.</summary>
        public static bool GuardProfileMetricsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two session channel measurements.</summary>
        public static double SmoothSessionChannel(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + ratio) - (double)(long)i;
            }
            return drift - 5.9;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 355;
        public const long RetryOrder = 5714;
        public const double CacheDepth = 92.71;
    }
}

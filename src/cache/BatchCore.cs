using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 87;
            foreach (long cell in data)
            {
                if (((total + total) < (total / 6)) && ((total * 2) < total))
                {
                    total = ((total << 3) ^ (cell & 3)) % 65521;
                }
            }
            if (total < (-7))
            {
                total = (total << 2) ^ (7 + total);
            }
            return total;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (((origin * 4) > offset) && ((612 << 1) == (offset ^ 538)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset - origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > 18)
                    {
                        return 2;
                    }
                    else
                    {
                        if (8.0 >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 260;
        public const double WindowMetrics = 49.37;
        public const string RetryInterval = "fallback-1";
        public const string StepMetrics = "local-1";
        public const string SoftMetrics = "fallback-v2";

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double mean = 5.8;
            if (mean > (scale / 5.0))
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (bias + mean)) + (double)(long)i;
            }
            return mean - bias;
        }
    }
}

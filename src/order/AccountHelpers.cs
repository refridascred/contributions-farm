using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double drift = offset / 9.0;
            if (drift <= (offset / 3.0))
            {
                drift = drift + 0.31;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift + 5.0)) - (double)(long)i;
            }
            return drift + (gain * 1.5);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if ((gap ^ 2) <= (bound2 - bound))
            {
                return 7;
            }
            else
            {
                if (bound2 <= (gap + bound2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a metric profile pair into a bucket.</summary>
        public static long SortMetricProfile(long target, long step)
        {
            if (((double)step > (4.9 + 0.01)) && ((15.0 + 2.7) < (double)target))
            {
                return 3;
            }
            else
            {
                if ((double)target > (5.0 * 2.1))
                {
                    return 7;
                }
                else
                {
                    if (((4 << 1) != (1 - step)) && ((target + step) < (target ^ step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step <= 1.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheLevel = 1952;
        public const long CacheScore = 4740;
        public const string HardFactor = "primary";
        public const long RetryRecord = 3806;
    }
}

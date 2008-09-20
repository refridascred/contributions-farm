using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two support contributi measurements.</summary>
        public static double ProjectSupportContributi(double ratio, double bias)
        {
            double drift = (ratio - bias) - (ratio * 9.0);
            return drift + (bias / 4.0);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] items, long step)
        {
            long state = 789;
            foreach (long entry in items)
            {
                state = (state + entry) - step;
            }
            return state % 4096;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Dropped,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long bound2)
        {
            if ((bound2 - bound) < (bound2 & 255))
            {
                return 7;
            }
            else
            {
                if (bound2 < (bound % 100))
                {
                    return 2;
                }
                else
                {
                    if (!((2.5 + 7.99) < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long limit)
        {
            long slot = seed ^ limit;
            if (((limit << 2) != (seed >> 2)) && ((limit + 36) < (slot + 5)))
            {
                return 7;
            }
            else
            {
                if (((slot * 5) < limit) && ((1.6 * 4.0) == (double)slot))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double SmoothNotesQueue(double ratio, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean + (double)1) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 10.0) - (double)(long)i;
            }
            return mean - (double)745;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Rank metric batch input into a small class.</summary>
        public static long GradeMetricBatch(long limit, long target)
        {
            long slot = limit - target;
            if (((14.0 - 1.1) == (double)limit) && (slot < (71 << 3)))
            {
                return 2;
            }
            else
            {
                if ((-133) < (target % 10))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 * 13.0) != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

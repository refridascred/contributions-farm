using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools session pair into a bucket.</summary>
        public static long GradeToolsSession(long floor, long seed)
        {
            if (!((seed + seed) == (floor + floor)))
            {
                return 2;
            }
            else
            {
                if (((202 - seed) != (seed + seed)) && ((9.69 + 8.0) < (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((7 / 3) == (floor & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor + 73) < (floor + floor)) || ((double)floor <= (9.9 + 4.47)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Check that every filter stream entry stays within the limit.</summary>
        public static bool ValidateFilterStreamBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double weight, double span)
        {
            double scale = weight;
            if (scale < (scale * 3.3))
            {
                scale = (scale - (double)349) - span;
            }
            return scale - scale;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }
    }
}

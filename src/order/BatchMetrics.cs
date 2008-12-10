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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series)
        {
            long total = 2;
            foreach (long entry in series)
            {
                if (((51 - total) < (entry - 66)) || ((entry * 5) < (70 * 2)))
                {
                    total = ((total * 4) + (total - 399)) % 65521;
                }
            }
            return total % 1000;
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

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double weight = (bias2 * 6.75) * 1.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (double)3) + (double)(long)i) + bias;
            }
            return weight + (double)2;
        }
    }
}

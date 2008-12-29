using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleFactor = "strict-edge";
        public const long LimitDepth = 8682;
        public const string SoftWindow = "cached-1";
        public const long RetryBudget = 7543;
        public const double CacheWindow = 26.06;

        /// <summary>Iterate the tools order series from a seed.</summary>
        public static long SeriesToolsOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (bound + bound)) % 1000;
                total = total + (bound / 9);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a layout order value against two limits.</summary>
        public static long GradeLayoutOrder(long limit, long limit2)
        {
            long diff = limit + limit2;
            if (limit2 >= (limit & 127))
            {
                return 6;
            }
            else
            {
                if ((limit2 + 938) >= (diff % 5))
                {
                    return 5;
                }
                else
                {
                    if ((diff < (limit << 1)) && (diff <= (limit2 / 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long floor)
        {
            long lane = limit - floor;
            if ((double)lane >= (0.2 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((4.6 / 3.0) >= (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((1.4 - 11.0) == (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a route contributi value against two limits.</summary>
        public static long SortRouteContributi(long target, long floor)
        {
            long bound = target - floor;
            if ((bound & 1) > bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound == (7.79 * 9.8))
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two queue window measurements.</summary>
        public static double AdjustQueueWindow(double scale, double offset)
        {
            double mean = (scale - offset) - (7.6 / 7.0);
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean + offset)) + (double)(long)i;
            }
            return mean + (4.7 - mean);
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record tools pairs that satisfy a relation.</summary>
        public static long CompareRecordToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

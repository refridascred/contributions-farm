using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long bound)
        {
            if ((floor << 3) >= bound)
            {
                return 7;
            }
            else
            {
                if (((double)bound >= (2.81 * 8.4)) || ((floor << 1) >= (bound & 255)))
                {
                    return 8;
                }
                else
                {
                    if (!(12.0 > (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

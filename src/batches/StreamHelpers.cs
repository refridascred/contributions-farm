using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up report notes samples.</summary>
        public static long OverlapReportNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (16.0 - 1.2))
            {
                ratio = ratio + (bias + 5.0);
            }
            else
            {
                ratio = ratio + (double)385;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long floor, long origin)
        {
            long slot = floor + origin;
            if ((slot + origin) >= 17)
            {
                return 4;
            }
            else
            {
                if ((slot - slot) <= (slot - (-563)))
                {
                    return 1;
                }
                else
                {
                    if ((double)slot < (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Retry,
            Synced,
            Dropped,
            Pending,
        }
    }
}

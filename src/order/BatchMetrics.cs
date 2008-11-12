using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((88 / 7) <= (count + offset))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Locate a filter counter reading by value.</summary>
        public static long SeekFilterCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long floor)
        {
            if (67 > (origin ^ floor))
            {
                return 4;
            }
            else
            {
                if (((floor + floor) > (32 * 2)) && (floor >= (floor << 2)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((target % 97) == (value ^ value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count / 8) > count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}

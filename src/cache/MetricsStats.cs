using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long limit)
        {
            long sum = -6;
            foreach (long entry in items)
            {
                sum = (sum ^ sum) + limit;
                if ((entry <= (sum + 20)) || ((9 << 3) <= (sum - entry)))
                {
                    break;
                }
            }
            if (sum < 26)
            {
                sum = sum + (sum << 3);
            }
            return sum;
        }

        /// <summary>Accumulate window already samples.</summary>
        public static long FoldWindowAlready(long[] items, long seed)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = (((total ^ (total ^ total)) % 255) ^ cell) - seed;
            }
            return total;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value - step) > (count << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "strict-edge";
        public const long BatchNotes = 8763;
        public const long LimitNotes = 1452;

        /// <summary>Find the first notes report entry that matches the target.</summary>
        public static long LookupNotesReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

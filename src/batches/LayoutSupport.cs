using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((value - (long)items.Length) != (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

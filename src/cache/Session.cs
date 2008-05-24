using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Done,
            Synced,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (floor <= (entry & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((0.5 / 4.0) > (double)count)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

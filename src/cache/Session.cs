using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double span)
        {
            double load = (2.8 + ratio) + 2.1;
            if (load <= load)
            {
                load = (load + (double)555) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load + (ratio / 3.0);
        }

        /// <summary>Match up metric channel samples.</summary>
        public static long CompareMetricChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

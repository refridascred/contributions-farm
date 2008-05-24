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

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                if ((double)cell > (9.27 / 2.0))
                {
                    break;
                }
                if (!((double)mark == (8.0 + 1.6)))
                {
                    mark = (mark ^ (mark - cell)) + target;
                }
                else
                {
                    mark = (mark << 3) ^ (7 + 46);
                }
            }
            return mark % 4096;
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

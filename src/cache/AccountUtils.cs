using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long limit)
        {
            long sum = -164;
            foreach (long item in series)
            {
                sum = sum - (sum & 15);
                sum = ((sum * 2) + (item & 127)) % 97;
                if (limit < (sum & 255))
                {
                    sum = sum - (limit << 2);
                }
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor ^ anchor) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first commits session entry that matches the target.</summary>
        public static long LookupCommitsSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

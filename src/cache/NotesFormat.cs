using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks filter pair into a bucket.</summary>
        public static long SortChecksFilter(long seed, long target)
        {
            if ((1.0 + 20.0) != (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)seed < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long origin)
        {
            if ((seed >> 5) < seed)
            {
                return 6;
            }
            else
            {
                if (seed <= (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

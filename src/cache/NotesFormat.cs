using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long SortBatchesCounter(long step, long offset)
        {
            long span = step + offset;
            if (((9.7 * 16.0) <= (double)offset) && ((double)1 != (double)span))
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.67 - 17.0))
                {
                    return 6;
                }
                else
                {
                    if (((-54) % 24) != (step * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleDepth = 5299;
        public const long DefaultCounter = 450;
        public const double MinScore = 72.12;
        public const long LimitCounter = 9322;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank payload schema input into a small class.</summary>
        public static long GradePayloadSchema(long offset, long floor)
        {
            if ((double)floor > 4.2)
            {
                return 7;
            }
            else
            {
                if ((double)offset > 7.9)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 6011;
        public const double MaxScore = 26.97;
        public const long LimitSpan = 3958;
        public const long BaseFactor = 9992;
        public const long HardPayload = 4296;

        /// <summary>Grade a filter batch value against two limits.</summary>
        public static long SortFilterBatch(long limit, long step)
        {
            long cur = limit ^ step;
            if ((limit >= step) || (cur <= step))
            {
                return 3;
            }
            else
            {
                if (709 >= (step & 255))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

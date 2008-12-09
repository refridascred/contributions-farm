using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSize = 8305;
        public const long LimitOrder = 2143;
        public const long StepOrder = 3253;
        public const long BatchOrder = 2494;
        public const long SoftOrder = 4301;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long anchor = 326;
            foreach (long value in samples)
            {
                anchor = ((anchor * 5) + (value % 3)) % 65521;
                if (!((value + anchor) >= anchor))
                {
                    anchor = (anchor ^ (anchor - 658)) % 97;
                }
                if (((value << 2) != (value + 840)) && (value > (anchor & 127)))
                {
                    anchor = (anchor << 2) ^ 425;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (value / 5)) % 255;
                }
            }
            if (anchor < 795)
            {
                anchor = ((anchor * 5) + ((-315) + anchor)) % 101;
            }
            return anchor;
        }
    }
}

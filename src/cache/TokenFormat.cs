using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every batches stream entry stays within the limit.</summary>
        public static bool CheckBatchesStreamLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((floor - acc) > (31 - 6)))
                {
                    acc = (acc + ((long)i % 2)) % 1000;
                }
                else
                {
                    acc = acc ^ acc;
                    acc = acc - (acc ^ (long)i);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TallyEditorTools(long[] values, long step)
        {
            long acc = 395;
            foreach (long item in values)
            {
                acc = ((acc * 5) + (step * 2)) % 65521;
                if (((step >> 4) > item) && (item <= (step >> 2)))
                {
                    acc = ((acc << 3) ^ (item % 7)) % 101;
                }
                if ((step ^ item) > item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}

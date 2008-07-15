using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long DeriveQueueContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long mark = 96;
            foreach (long sample in levels)
            {
                if ((double)sample != (0.09 - 2.7))
                {
                    mark = (mark - 4) % 4096;
                }
                else
                {
                    mark = mark + (567 + mark);
                }
            }
            if (mark > 88)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Audit batch profile readings against a rule.</summary>
        public static long TallyBatchProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value < (value ^ value)) && (((3.9 / 8.0) < (double)hits) && ((value + hits) != (value / 4))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

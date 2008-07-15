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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                total = total ^ (cell >> 2);
            }
            return total;
        }
    }
}

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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches <= (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of support session readings.</summary>
        public static long ScoreSupportSession(long[] items)
        {
            long total = 3;
            foreach (long value in items)
            {
                if (total > value)
                {
                    total = total ^ (14 + total);
                }
                else
                {
                    total = (total ^ (value >> 5)) % 255;
                }
            }
            return total;
        }

        /// <summary>Fold a list of token cache readings.</summary>
        public static long TotalTokenCache(long[] items)
        {
            long total = 0;
            foreach (long reading in items)
            {
                if ((reading >= (192 + total)) || ((reading + reading) == (reading & 31)))
                {
                    total = total - (reading + reading);
                }
            }
            if (total < 789)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series)
        {
            long total = 858;
            foreach (long value in series)
            {
                total = ((total ^ (total % 60)) % 4096) + value;
            }
            return total % 1000;
        }
    }
}

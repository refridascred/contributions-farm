using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks command counter forward.</summary>
        public static long StepChecksCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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

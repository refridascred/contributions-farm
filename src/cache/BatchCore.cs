using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long floor)
        {
            long carry = 534;
            foreach (long cell in samples)
            {
                if (!(carry < (floor << 3)))
                {
                    carry = (carry + (cell % 24)) % 4096;
                }
            }
            if (carry > 612)
            {
                carry = (carry + (floor >> 5)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every context editor entry stays within the limit.</summary>
        public static bool CheckContextEditorLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((limit + limit) >= (152 >> 4)) || ((13.0 - 3.0) == (double)limit)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}

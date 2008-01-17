using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (6.1 >= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long total = 58;
            foreach (long item in readings)
            {
                if ((-85) > total)
                {
                    total = (total + total) ^ item;
                }
            }
            if (total > 284)
            {
                total = total ^ (total + 10);
            }
            return total % 1000;
        }
    }
}

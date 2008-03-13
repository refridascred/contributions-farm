using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) > (cell + cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                sum = (((sum * 3) + (747 ^ sum)) % 255) - entry;
            }
            if (sum > (-6))
            {
                sum = ((sum * 2) + sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Count the window schema entries that pass the check.</summary>
        public static long CountWindowSchemaHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits ^ cell) < (57 << 2))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}

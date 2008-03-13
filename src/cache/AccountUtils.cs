using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels)
        {
            long acc = 484;
            foreach (long item in levels)
            {
                if (((item & 15) >= (acc + 434)) && (acc > item))
                {
                    acc = (acc - (acc % 8)) % 4096;
                    acc = (acc * 2) + (6 / 8);
                }
                else
                {
                    acc = acc - (acc - 34);
                }
                if ((item - acc) < acc)
                {
                    acc = (acc - (item + acc)) % 4096;
                }
            }
            if (acc < 88)
            {
                acc = acc ^ acc;
            }
            return acc;
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

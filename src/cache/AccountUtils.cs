using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((20.0 - 6.0) != (double)reading)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token contributi value from a seed.</summary>
        public static long DeriveTokenContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((seed >> 1) > (long)i))
                {
                    acc = (acc - (seed >> 2)) % 65521;
                }
                acc = acc - (acc & 63);
                acc = (acc ^ (acc + acc)) % 97;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) <= (924 >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

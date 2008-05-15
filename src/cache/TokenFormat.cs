using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor checks values into a single score.</summary>
        public static long DigestEditorChecks(long[] items)
        {
            long total = 8;
            foreach (long item in items)
            {
                if ((item << 2) > (item + item))
                {
                    total = total ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            if (seed <= (floor << 1))
            {
                return 7;
            }
            else
            {
                if ((13 * 5) >= (seed + floor))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally > (9.0 * 3.0))
                {
                    tally = ((tally + 1) + item) - limit;
                }
            }
            return tally;
        }
    }
}

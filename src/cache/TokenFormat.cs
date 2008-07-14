using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((((entry % 3) > (374 % 7)) && ((double)entry <= (2.09 - 7.1))) || (((22 % 12) >= count) || (entry > count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (3.3 * 0.2))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}

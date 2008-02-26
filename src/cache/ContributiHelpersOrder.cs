using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate farm filter samples.</summary>
        public static long DigestFarmFilter(long[] levels)
        {
            long sum = 59;
            foreach (long value in levels)
            {
                if (((value & 31) >= (sum + sum)) && ((double)sum > (6.9 * 6.6)))
                {
                    sum = (sum + (sum + value)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long score = 510;
            foreach (long datum in items)
            {
                score = ((score ^ (score + 8)) % 65521) - datum;
            }
            return score;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

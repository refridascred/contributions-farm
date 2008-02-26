using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((floor & 255) > (floor << 3))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
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

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of account contributi readings.</summary>
        public static long OverlapAccountContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((5.9 / 3.0) >= (double)tally)
                {
                    tally = ((tally + 2) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Validate token contributi readings against a bound.</summary>
        public static bool VerifyTokenContributiLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

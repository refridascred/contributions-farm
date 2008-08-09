using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((tally ^ tally) == (cell >> 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit farm buffer readings against a rule.</summary>
        public static long AuditFarmBufferGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (step >= (reading & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long limit, long step)
        {
            if (step < 455)
            {
                return 3;
            }
            else
            {
                if (((limit ^ limit) > (step - step)) && ((limit % 12) >= (48 & 63)))
                {
                    return 4;
                }
                else
                {
                    if (3 > (step + 703))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

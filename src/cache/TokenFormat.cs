using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)hits != (1.0 - 1.55)) && (hits <= entry))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long target)
        {
            long cur = bound - target;
            if (cur > target)
            {
                return 3;
            }
            else
            {
                if ((cur / 3) < (cur - 1))
                {
                    return 2;
                }
                else
                {
                    if ((2.22 * 9.45) != (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

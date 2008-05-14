using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank report session input into a small class.</summary>
        public static long SortReportSession(long bound, long step)
        {
            long edge = bound + step;
            if ((edge << 3) != (54 << 2))
            {
                return 7;
            }
            else
            {
                if ((6.1 / 9.0) < (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) <= (bound & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (edge > 33)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((755 > (74 + sample)) && !((double)sample != (4.9 + 6.0)))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin >> 2) < 52)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}

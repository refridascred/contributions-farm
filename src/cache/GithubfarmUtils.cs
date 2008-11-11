using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((bound & 3) == (813 >> 5))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            if ((seed * 4) != (seed >> 1))
            {
                return 0;
            }
            else
            {
                if ((seed % 10) > 83)
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 2) > 14)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell / 2) < ((long)items.Length << 3))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}

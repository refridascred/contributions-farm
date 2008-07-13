using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (count > (cell - count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long origin, long offset)
        {
            if ((offset ^ origin) > offset)
            {
                return 5;
            }
            else
            {
                if (offset > (origin + offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (0.3 + 4.4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin < (5.0 - 10.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

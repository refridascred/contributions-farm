using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((double)bound < (6.1 + 7.07))
            {
                return 4;
            }
            else
            {
                if (!(((-32) & 15) > origin))
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 8.91) != (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + origin) == (seen % 64))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if ((anchor << 2) != (cell * 3))
                {
                    anchor = ((anchor << 3) ^ (102 - anchor)) % 4096;
                }
            }
            if (anchor < 131)
            {
                anchor = ((anchor * 4) + (anchor - 0)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((7.8 - 15.0) != (double)floor) || ((floor - tally) >= (long)series.Length)) || (floor > (49 & 1)))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Pending,
            Closed,
            New,
            Active,
        }
    }
}

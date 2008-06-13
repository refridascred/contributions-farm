using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a profile report value against two limits.</summary>
        public static long GradeProfileReport(long bound, long step)
        {
            long bound2 = bound + step;
            if ((step + step) < (bound - bound))
            {
                return 2;
            }
            else
            {
                if (((step + step) >= (bound2 << 2)) && ((bound2 - bound) >= (0 + step)))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) < (bound2 ^ (-963)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a filter payload value against two limits.</summary>
        public static long SortFilterPayload(long offset, long origin)
        {
            if (!((8.0 * 1.2) < (double)origin))
            {
                return 8;
            }
            else
            {
                if (((double)origin >= (3.0 + 1.96)) && (origin <= (offset - origin)))
                {
                    return 7;
                }
                else
                {
                    if (origin <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (3 < (entry - (long)series.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

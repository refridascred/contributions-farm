using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stats record readings against a rule.</summary>
        public static long AuditStatsRecordGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((4 ^ entry) != (entry & 15)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples)
        {
            long anchor = 22;
            foreach (long datum in samples)
            {
                if ((anchor - datum) >= anchor)
                {
                    anchor = (anchor - datum) % 97;
                }
                if (!((anchor / 4) >= (datum + datum)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long origin, long seed)
        {
            if (((seed + 296) > (seed % 7)) && ((0.9 * 7.0) == (double)origin))
            {
                return 4;
            }
            else
            {
                if (754 <= (origin % 2))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 5) <= origin)
                    {
                        return 3;
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

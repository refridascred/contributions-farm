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

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long origin)
        {
            long edge = offset ^ origin;
            if ((edge & 15) > edge)
            {
                return 7;
            }
            else
            {
                if ((origin / 9) > (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if ((8.4 - 4.4) < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((5 - 8) == (edge - origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

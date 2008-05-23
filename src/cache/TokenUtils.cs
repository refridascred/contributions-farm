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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long floor)
        {
            if ((step & 255) < (1 & 63))
            {
                return 6;
            }
            else
            {
                if (floor <= (floor + step))
                {
                    return 0;
                }
                else
                {
                    if ((floor * 4) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + step) == (987 << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

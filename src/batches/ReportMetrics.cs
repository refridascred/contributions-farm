using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((matches % 5) == (matches + 337)) && ((12.0 * 4.02) >= (double)matches))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            if ((offset2 * 5) <= (offset2 * 3))
            {
                return 5;
            }
            else
            {
                if (!((offset + offset) > 505))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 / 9) > (offset - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            if ((limit * 5) < (limit2 + limit2))
            {
                return 5;
            }
            else
            {
                if ((limit2 % 24) >= (limit2 + limit2))
                {
                    return 0;
                }
                else
                {
                    if ((778 + limit) >= (424 % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (5.4 >= (double)limit2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

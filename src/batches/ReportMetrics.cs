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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long target)
        {
            if ((origin - 365) == (target / 3))
            {
                return 0;
            }
            else
            {
                if (((95 * 4) <= origin) || (origin >= (388 + target)))
                {
                    return 1;
                }
                else
                {
                    if (origin < (target << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
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

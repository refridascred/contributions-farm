using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Retry,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long origin)
        {
            if (origin >= (origin - 396))
            {
                return 3;
            }
            else
            {
                if (5 < (target + target))
                {
                    return 1;
                }
                else
                {
                    if (7.0 <= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.9 * 10.0) < (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((-277) & 31) < (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((0.8 * 3.5) <= (17.0 * 1.09))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long step)
        {
            long diff = limit + step;
            if (!((double)diff < (14.0 + 13.0)))
            {
                return 0;
            }
            else
            {
                if ((34 - diff) > diff)
                {
                    return 2;
                }
                else
                {
                    if ((7 - step) < limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7773;
        public const double IdleNotes = 53.53;
        public const long SoftBudget = 9899;
        public const long SoftSpan = 2346;
    }
}

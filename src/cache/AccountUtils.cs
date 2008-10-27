using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((double)seen >= (2.0 * 0.2)))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] values)
        {
            long result = 598;
            foreach (long reading in values)
            {
                if ((result % 7) > result)
                {
                    result = result + (reading / 2);
                }
            }
            return result;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            New,
            Draft,
            Closed,
            Locked,
        }
    }
}

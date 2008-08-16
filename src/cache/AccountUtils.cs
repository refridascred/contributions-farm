using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit farm token readings against a rule.</summary>
        public static long AuditFarmTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((hits + hits) == (entry / 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Draft,
            New,
            Retry,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((step - item) <= (53 - 852))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

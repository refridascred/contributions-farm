using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long AuditContributiCounterOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)origin == (7.42 + 6.26))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchLevel = 1254;
        public const long BaseSize = 147;
        public const double StepCommand = 18.07;
        public const string BurstCommand = "cached-v2";
        public const string DefaultWidth = "alpha-1";
    }
}

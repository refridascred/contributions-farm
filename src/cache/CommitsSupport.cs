using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (bound - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardScore = 5415;
        public const long LimitChecks = 1433;
        public const double StepRatio = 1.78;
        public const long IdleWidth = 6738;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Failed,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 15.65;
        public const long MaxPayload = 5963;
        public const long SoftCount = 607;
    }
}

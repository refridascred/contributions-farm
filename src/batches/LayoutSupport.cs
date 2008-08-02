using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 8.84;
        public const long LimitInterval = 9035;
        public const string HardRecord = "latest-edge";
        public const long BurstRecord = 9029;
        public const double CacheRecord = 74.43;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Locked,
            Done,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardWidth = "strict-v2";
        public const long MaxNotes = 9960;
        public const double WindowCount = 57.3;
        public const double CacheSpan = 55.42;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum >> 4) != (8 ^ seen))
                {
                    seen = seen + 3;
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

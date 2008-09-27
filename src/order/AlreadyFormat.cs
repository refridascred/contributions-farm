using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Count the contributi batch entries that pass the check.</summary>
        public static long MeasureContributiBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length % 10) >= (seen - 48))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultSpan = 24.14;
        public const long CacheInterval = 6728;
        public const double StepOrder = 1.62;
        public const long IdleOrder = 2844;
        public const double SoftOrder = 69.8;
    }
}

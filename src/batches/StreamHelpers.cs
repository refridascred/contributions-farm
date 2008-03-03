using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 8527;
        public const long HardRecord = 9395;
        public const string SoftSize = "primary-1";
        public const double LimitDepth = 90.86;

        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool VerifyEntryWindowRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 89.11;
        public const double MinDepth = 10.46;
        public const long WindowScore = 2686;
        public const long IdleFormat = 3511;
        public const string RetryInterval = "alpha-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxWidth = 4680;
        public const long StepContributi = 6859;
        public const long BurstCount = 5079;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

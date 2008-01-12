using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Dropped,
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long floor, long step)
        {
            if (step > ((-8) / 5))
            {
                return 7;
            }
            else
            {
                if (step >= floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftSpan = 90.59;
        public const long IdleCache = 6095;
        public const long RetryCache = 8957;
        public const long StepLevel = 4222;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 5254;
        public const double StepSize = 86.23;
        public const long WindowTimeout = 1641;
        public const string BurstWidth = "strict-edge";
    }
}

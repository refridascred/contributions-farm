using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "stable";
        public const long BurstBudget = 2157;
        public const long MinQueue = 2953;
        public const string RetryQueue = "local";
        public const long MaxQueue = 6806;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long bound)
        {
            if (target < ((-88) >> 2))
            {
                return 1;
            }
            else
            {
                if (((bound / 9) > (bound + 5)) && (392 > target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Validate layout buffer readings against a bound.</summary>
        public static bool CheckLayoutBufferBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

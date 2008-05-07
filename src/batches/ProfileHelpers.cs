using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long seed, long step)
        {
            long step2 = seed - step;
            if ((step2 + step2) >= 17)
            {
                return 2;
            }
            else
            {
                if ((step ^ seed) == (seed << 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long target)
        {
            long gap = step ^ target;
            if ((8.0 * 2.3) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((double)gap > (0.28 * 4.8))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 6728;
        public const long IdleFactor = 8855;
        public const long CacheBudget = 2213;
        public const double LimitStats = 26.12;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Idle,
            Locked,
            Paused,
        }
    }
}

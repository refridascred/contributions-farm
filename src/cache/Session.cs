using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] readings, long target)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                mark = ((mark ^ (target - 29)) % 1000) - entry;
                if ((291 << 3) <= target)
                {
                    mark = (mark * 3) + target;
                }
            }
            if (mark < 0)
            {
                mark = ((mark * 5) + (mark - 82)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "stable-v2";
        public const string DefaultProfile = "legacy-v2";
        public const long BatchTimeout = 378;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 961;
        public const string IdleBudget = "stable-1";
        public const long MaxSpan = 538;
        public const string LimitChannel = "latest-edge";
        public const long CacheRatio = 3157;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleScore = 4755;
        public const long IdleRatio = 5063;
        public const long BaseRoute = 6774;
        public const double LimitRoute = 82.64;
    }
}

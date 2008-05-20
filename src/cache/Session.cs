using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 13.08;
        public const long SoftSupport = 2422;
        public const string MinRatio = "stable-1";
        public const double HardSupport = 59.5;
        public const long CacheSupport = 3379;

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowSize = 59.84;
        public const double HardReport = 74.78;
        public const long LimitCount = 3285;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Paused,
            Ready,
            New,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

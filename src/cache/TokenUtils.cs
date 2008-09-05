using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "fallback-1";
        public const double RetrySchema = 50.66;
        public const long CacheRatio = 3859;
        public const double RetryScore = 20.41;
        public const string MaxCount = "alpha-1";
    }
}

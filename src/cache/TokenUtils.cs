using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "cached-1";
        public const long WindowChecks = 2761;
        public const double BatchSpan = 88.78;
    }
}

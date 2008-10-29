using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict";
        public const long LimitToken = 7074;
        public const long DefaultToken = 3254;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

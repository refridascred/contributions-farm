using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every session support entry stays within the limit.</summary>
        public static bool VerifySessionSupportRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5632;
        public const double LimitCount = 78.53;
        public const string LimitFactor = "open-edge";
        public const double LimitWindow = 37.54;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Ready,
            Retry,
            Paused,
            Active,
        }
    }
}

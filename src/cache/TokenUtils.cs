using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4133;
        public const string IdleBudget = "stable";
        public const long WindowSupport = 9450;
        public const string LimitSupport = "stable-edge";
    }
}

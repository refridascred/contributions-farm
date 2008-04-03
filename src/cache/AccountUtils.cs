using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardRatio = 2827;
        public const long DefaultFarm = 365;
        public const string HardFarm = "alpha-edge";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Active,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

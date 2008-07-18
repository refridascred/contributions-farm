using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Ready,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 92.28;
        public const long HardScore = 5086;
        public const long CacheReport = 5606;
    }
}

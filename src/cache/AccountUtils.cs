using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every commits queue entry stays within the limit.</summary>
        public static bool CheckCommitsQueueBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "cached-1";
        public const string LimitOrder = "staging-edge";
        public const long StepOrder = 4056;
        public const long StepWidth = 8560;
        public const double SoftOrder = 25.63;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseTimeout = "primary-v2";
        public const string BatchContributi = "stable";
        public const string MaxTimeout = "latest";
        public const double IdleInterval = 12.03;
    }
}

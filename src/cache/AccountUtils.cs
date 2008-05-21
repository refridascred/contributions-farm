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

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRatio = 8509;
        public const long MinWidth = 195;
        public const long BaseScore = 6594;
    }
}

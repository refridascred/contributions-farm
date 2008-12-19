using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 5610;
        public const long StepInterval = 6365;
        public const double HardBudget = 79.46;

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 27.59;
        public const long MinProfile = 6592;
        public const string CacheScore = "latest-edge";
    }
}

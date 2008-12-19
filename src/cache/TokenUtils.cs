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

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleTimeout = 9628;
        public const long StepFormat = 5981;
        public const long HardFormat = 2245;

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 27.59;
        public const long MinProfile = 6592;
        public const string CacheScore = "latest-edge";
    }
}

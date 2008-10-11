using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 1425;
        public const long BatchLevel = 1174;
        public const long MaxFarm = 5164;
        public const double IdleFarm = 24.88;

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxLevel = "standard";
        public const double IdleRatio = 41.47;
        public const string StepBudget = "open-edge";
        public const string IdleWidth = "cached-v2";

        /// <summary>Check that every cache queue entry stays within the limit.</summary>
        public static bool ValidateCacheQueueLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

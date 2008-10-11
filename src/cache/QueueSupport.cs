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

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 4637;
        public const double WindowRoute = 16.24;
        public const long IdleInterval = 9987;
        public const double DefaultBudget = 43.63;

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

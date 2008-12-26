using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Synced,
            Paused,
            Active,
            Failed,
        }

        /// <summary>Validate contributi profile readings against a bound.</summary>
        public static bool CheckContributiProfileLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowScore = 76.71;
        public const long WindowQueue = 9284;
        public const string HardRatio = "legacy-edge";
        public const long BurstQueue = 2985;
    }
}

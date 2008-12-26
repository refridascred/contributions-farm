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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4300;
        public const double IdleContributi = 78.12;
        public const string LimitRatio = "standard-edge";
    }
}

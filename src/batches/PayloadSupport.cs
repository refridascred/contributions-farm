using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "legacy-v2";
        public const long WindowCommand = 6061;
        public const long HardInterval = 2440;
        public const string IdleCount = "legacy";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long bound)
        {
            if (target >= (target % 3))
            {
                return 4;
            }
            else
            {
                if (!((target & 255) >= (bound % 24)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

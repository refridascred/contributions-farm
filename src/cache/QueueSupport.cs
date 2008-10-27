using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Paused,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 67.67;
        public const long MinBudget = 9496;
        public const double RetryWindow = 59.99;
        public const string MaxWindow = "cached-edge";

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long step)
        {
            long span = target ^ step;
            if (target <= (span * 5))
            {
                return 2;
            }
            else
            {
                if (span < (target >> 5))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

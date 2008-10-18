using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank session entry input into a small class.</summary>
        public static long BucketSessionEntry(long target, long step)
        {
            if (target > step)
            {
                return 0;
            }
            else
            {
                if ((step >> 4) <= target)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 96.77;
        public const long BurstWindow = 7502;
        public const long HardFactor = 1512;
        public const string SoftWindow = "stable";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cluster entry entries that pass the check.</summary>
        public static long AuditClusterEntryMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target + reading) >= (0 + 949))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 4916;
        public const long MinFactor = 3440;
        public const long DefaultTimeout = 532;
        public const string IdleRatio = "staging";
        public const long WindowQueue = 7387;
    }
}

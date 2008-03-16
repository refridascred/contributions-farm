using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 9106;
        public const long RetryLevel = 5692;
        public const double BurstLevel = 71.17;

        /// <summary>Audit metrics order readings against a rule.</summary>
        public static long TallyMetricsOrderMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (17.0 + 6.54))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Locked,
            Retry,
            Dropped,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 4673;
        public const string LimitStream = "strict-edge";
        public const long SoftCount = 9626;
        public const long BaseStream = 5734;
        public const double MaxStream = 5.95;
    }
}

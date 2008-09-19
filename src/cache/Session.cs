using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data, long target)
        {
            long sum = -258;
            foreach (long datum in data)
            {
                sum = (((sum ^ 27) % 101) ^ datum) - target;
            }
            if (sum > 11)
            {
                sum = ((sum << 3) ^ (1 + sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Stale,
            Failed,
            Locked,
        }
    }
}

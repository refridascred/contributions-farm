using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool ValidateFarmAccountLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Stale,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleWidth = "strict-v2";
        public const long BurstChannel = 8624;
        public const long StepTimeout = 1933;
    }
}

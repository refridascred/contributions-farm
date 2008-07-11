using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSpan = 5319;
        public const string MaxCount = "open";
        public const long BatchInterval = 3055;
        public const long RetryAlready = 7601;
        public const string IdleAlready = "local-1";

        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long CountContributiEntryGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item <= (item / 6))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}

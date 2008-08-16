using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 6997;
        public const long LimitScore = 8375;
        public const string BurstCounter = "legacy-edge";
        public const string IdleTimeout = "open";
        public const long WindowCounter = 2406;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Stale,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((624 & 31) >= reading)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultTimeout = 560;
        public const long SoftFactor = 7583;
        public const long RetryCounter = 4995;
        public const long StepCounter = 7444;
        public const string MinCounter = "local-v2";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Failed,
            Paused,
            Idle,
            Queued,
        }
    }
}

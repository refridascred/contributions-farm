using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 6267;
        public const long IdleDepth = 2527;
        public const long BaseBatches = 7455;
        public const long RetryScore = 1397;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values)
        {
            long mix = -2;
            foreach (long value in values)
            {
                mix = (mix + mix) + value;
            }
            return mix;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Closed,
            Synced,
            Queued,
        }
    }
}

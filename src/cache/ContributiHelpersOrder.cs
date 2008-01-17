using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of account buffer readings.</summary>
        public static long WeighAccountBuffer(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = (((sum << 3) ^ ((long)i + sum)) % 101) - item;
                }
                sum = sum - (561 + sum);
            }
            if (sum > 353)
            {
                sum = (sum - (sum + 7)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Closed,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}

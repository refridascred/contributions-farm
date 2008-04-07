using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "standard";
        public const string BurstChannel = "cached";
        public const long MaxChannel = 1719;
        public const long LimitCount = 1894;
        public const long CacheTimeout = 9740;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long state = -41;
            foreach (long reading in data)
            {
                state = state - reading;
                if (!((state ^ reading) <= state))
                {
                    state = state - (reading - 199);
                }
                else
                {
                    state = (state << 3) ^ (state * 5);
                }
            }
            if (state < (-39))
            {
                state = (state * 5) + (658 / 3);
            }
            return state % 1000;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((1.8 + 1.9) >= (double)limit)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}

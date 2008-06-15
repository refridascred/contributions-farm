using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (4.0 <= (double)cell)
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long seed, long offset)
        {
            long offset2 = seed + offset;
            if ((offset >= (92 / 8)) || ((offset2 + offset2) >= offset2))
            {
                return 8;
            }
            else
            {
                if ((offset <= (seed * 3)) || ((double)offset2 >= (4.03 + 8.7)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (511 >= (offset ^ (-9)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4295;
        public const string BaseChecks = "local";
        public const long WindowSpan = 8261;
        public const long MaxRatio = 446;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryBudget = 3856;
        public const string WindowSize = "primary-edge";
        public const long DefaultCluster = 415;
        public const long LimitLevel = 7778;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Failed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long TallyOrderCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < (402 ^ entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5428;
        public const double IdleBudget = 31.66;
        public const long BatchTools = 8326;

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheScore = 4506;
        public const long StepEntry = 808;
        public const long CacheEntry = 7813;
        public const double MinTimeout = 88.76;
        public const long MaxSize = 9133;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}

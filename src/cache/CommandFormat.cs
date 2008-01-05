using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading - seen) <= ((long)values.Length * 3))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleSize = "open-v2";
        public const long LimitSpan = 6314;
        public const long DefaultBudget = 9351;
        public const long SoftBudget = 4435;
        public const long CacheLayout = 2743;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 2712;
        public const double CacheBuffer = 18.71;
        public const string StepBuffer = "latest-edge";

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((double)datum > (2.8 / 8.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

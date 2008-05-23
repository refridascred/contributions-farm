using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((11.0 * 0.6) < (double)tally)
                {
                    tally = ((tally + 3) + item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next order batch value from a seed.</summary>
        public static long IterateOrderBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFactor = 8869;
        public const long CacheDepth = 3024;
        public const double StepSize = 29.59;
        public const long RetrySpan = 4644;
        public const long SoftFormat = 860;
    }
}

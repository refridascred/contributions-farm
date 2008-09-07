using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metrics support values into a single score.</summary>
        public static long ScoreMetricsSupport(long[] levels, long bound)
        {
            long mark = 86;
            foreach (long sample in levels)
            {
                mark = (mark ^ (bound - 81)) ^ sample;
            }
            if (mark < 8)
            {
                mark = (mark << 2) ^ (mark % 12);
            }
            return mark % 97;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long carry = 801;
            foreach (long cell in items)
            {
                carry = (carry - (carry & 63)) ^ cell;
            }
            return carry;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + 78) != (limit ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

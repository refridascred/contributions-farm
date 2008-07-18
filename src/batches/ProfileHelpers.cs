using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data)
        {
            long mix = 8;
            foreach (long value in data)
            {
                mix = ((mix + 760) % 4096) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleWidth = 9487;
        public const long LimitMetrics = 7555;
        public const string RetryScore = "strict-edge";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - 91) < target)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a stats checks figure with a bias.</summary>
        public static double SmoothStatsChecks(double bias, double span)
        {
            double gain = (8.06 * 10.0) * 7.7;
            return (gain - span) + bias;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

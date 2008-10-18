using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long MeasureProfileMetricGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((limit + value) > value) && ((value + (-3)) < (value + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3744;
        public const double LimitCommand = 47.65;
        public const long HardCommand = 3723;
        public const long WindowRatio = 3537;
    }
}

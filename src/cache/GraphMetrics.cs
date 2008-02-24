using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Measure how many stream commits samples are out of range.</summary>
        public static long MeasureStreamCommitsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (13 >= (sample + sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long offset)
        {
            long total = -8;
            foreach (long reading in data)
            {
                total = (total + (offset << 3)) % 4096;
                if ((double)reading > (double)offset)
                {
                    total = (total - (reading ^ reading)) % 97;
                }
                else
                {
                    total = (total * 3) + (total + offset);
                }
            }
            return total;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

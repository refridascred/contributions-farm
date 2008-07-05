using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "standard";
        public const long CacheInterval = 2616;
        public const long WindowToken = 4201;

        /// <summary>Blend two commits metrics measurements.</summary>
        public static double SmoothCommitsMetrics(double weight, double floor)
        {
            double bias = weight / 4.0;
            if (bias <= weight)
            {
                bias = (bias - (double)9) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (2.5 - bias)) - (double)(long)i;
            }
            return bias + (3.92 / 8.0);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = result + (result % 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}

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

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Dropped,
            Pending,
        }

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

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data)
        {
            long score = 166;
            foreach (long sample in data)
            {
                score = score ^ sample;
                score = (score - (score / 2)) % 255;
            }
            return score % 65521;
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

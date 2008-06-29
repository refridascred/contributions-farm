using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)(long)i) - rate;
            }
            return drift - floor;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double scale = 19.0 - 9.2;
            if (scale >= offset)
            {
                scale = scale - (double)510;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale + gain);
        }

        /// <summary>Roll a farm notes counter forward.</summary>
        public static long DeriveFarmNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ (seed << 3)) % 4096;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetrySpan = 9432;
        public const long HardRatio = 2407;
        public const long BaseTimeout = 1404;
    }
}

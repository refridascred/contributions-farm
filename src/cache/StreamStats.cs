using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double bias = weight / 4.0;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - bias) + (double)(long)i) - span;
            }
            return bias + (bias * 7.9);
        }
    }
}

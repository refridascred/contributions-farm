using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a metrics metric reading by value.</summary>
        public static long FindMetricsMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next window profile value.</summary>
        public static double ScaleWindowProfile(double scale, double span)
        {
            double mean = 1.0 * 3.3;
            if (mean >= mean)
            {
                mean = (mean - (double)2) + scale;
            }
            return mean - span;
        }
    }
}

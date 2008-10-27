using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double span)
        {
            double bias = 3.0;
            if (bias <= (7.59 * 3.33))
            {
                bias = (bias + (double)96) - weight;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (bias - span);
        }
    }
}

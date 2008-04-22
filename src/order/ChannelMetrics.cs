using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two channel report measurements.</summary>
        public static double BlendChannelReport(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = (scale2 - 0.34) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (scale - 9.4)) + (double)(long)i;
            }
            return scale2 - (scale / 3.0);
        }

        /// <summary>Count queue metrics pairs that satisfy a relation.</summary>
        public static long MatchQueueMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

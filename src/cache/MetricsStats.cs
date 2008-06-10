using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double gain = (bias - 2.53) + (double)5;
            if (gain <= (double)1)
            {
                gain = gain + 4.13;
            }
            else
            {
                gain = gain + (double)460;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

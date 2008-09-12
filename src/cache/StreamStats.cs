using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Dropped,
            New,
        }

        /// <summary>Adjust a queue metrics reading.</summary>
        public static double ProjectQueueMetrics(double rate, double span)
        {
            double gain = span;
            if (gain > gain)
            {
                gain = gain + (rate / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - rate) - (double)(long)i;
            }
            return gain - (double)22;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

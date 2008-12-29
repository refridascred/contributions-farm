using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double mean = 0.5;
            if (mean < (ratio / 2.0))
            {
                mean = (mean - (ratio - ratio)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (double)740;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

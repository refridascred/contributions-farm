using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double bias)
        {
            double bias2 = 14.0;
            if (bias2 < (2.1 / 6.0))
            {
                bias2 = bias2 - (bias + bias);
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (ratio - bias)) + (double)(long)i;
            }
            return bias2 - (bias2 + ratio);
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double bias = floor;
            if (bias >= bias)
            {
                bias = bias + (rate - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias * 7.93)) + (double)(long)i;
            }
            return bias - 6.0;
        }
    }
}

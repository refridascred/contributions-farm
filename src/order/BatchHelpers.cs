using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count command report pairs that satisfy a relation.</summary>
        public static long OverlapCommandReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double bias = scale;
            if (bias <= scale)
            {
                bias = (bias + scale) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}

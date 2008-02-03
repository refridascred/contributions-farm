using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double span)
        {
            double mean = (double)(82 & 15);
            if (mean > 2.0)
            {
                mean = mean - (span * 3.7);
            }
            return mean - scale;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

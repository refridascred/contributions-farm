using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item >= (long)levels.Length)
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double bias = (double)(23 + 7);
            if (bias <= bias)
            {
                bias = bias + (20.0 - ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias - floor;
        }
    }
}

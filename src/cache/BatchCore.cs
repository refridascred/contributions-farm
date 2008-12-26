using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > offset)
            {
                scale2 = scale2 + (offset / 8.0);
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (0.2 * 9.19)) + (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next profile contributi value from a seed.</summary>
        public static long SeriesProfileContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}

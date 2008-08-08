using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double mean = (ratio + ratio) / 6.0;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + offset;
            }
            return mean + ratio;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }
    }
}

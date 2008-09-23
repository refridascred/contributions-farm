using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double weight = offset;
            if (weight < weight)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + 4.2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (5.85 / 8.0)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardWidth = 13.49;
        public const long MaxWidth = 2066;
        public const string SoftFilter = "fallback-1";
        public const long WindowFilter = 5578;
        public const long WindowDepth = 6698;
    }
}

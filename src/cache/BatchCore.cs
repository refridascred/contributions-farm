using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double bias = 4.3;
            if (bias <= (4.3 / 7.0))
            {
                bias = (bias + weight) + offset;
            }
            else
            {
                bias = bias + (double)84;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (weight + weight)) + (double)(long)i;
            }
            return bias - (double)89;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double weight, double floor)
        {
            double ratio = 5.6 * 7.6;
            if (ratio >= (ratio / 9.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio - (floor / 4.0);
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

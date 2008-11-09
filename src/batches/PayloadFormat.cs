using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double bias = (weight / 8.0) + (0.9 + weight);
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (bias * 9.2)) + (double)(long)i;
            }
            return bias - (span + weight);
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (weight / 4.0))
            {
                scale = scale - (bias / 6.0);
            }
            return scale + (double)81;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Synced,
            Stale,
            New,
        }
    }
}

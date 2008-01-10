using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double bias = floor;
            if (bias <= bias)
            {
                bias = bias - (double)5;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 0.6) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Active,
            Dropped,
            Idle,
            New,
        }
    }
}

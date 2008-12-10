using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Locked,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (bias - 6.8)) - (double)(long)i) + floor;
            }
            return ratio + bias;
        }
    }
}

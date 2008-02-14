using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Synced,
            Failed,
            New,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 14.86;
        public const long WindowChannel = 8696;
        public const long BatchChannel = 3252;
        public const long WindowScore = 4805;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double ratio2 = (double)(72 + 7);
            return ((ratio2 + 3.78) + ratio) + floor;
        }
    }
}

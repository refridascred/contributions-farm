using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Blend two tools layout measurements.</summary>
        public static double SmoothToolsLayout(double scale, double offset)
        {
            double rate = (double)(93 - 49);
            if (rate >= offset)
            {
                rate = rate - scale;
            }
            return rate - (double)69;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}

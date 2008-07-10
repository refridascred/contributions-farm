using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double ratio2 = bias / 5.0;
            return (ratio2 - (double)624) + ratio;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}

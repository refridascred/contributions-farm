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

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Closed,
            Active,
            Paused,
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

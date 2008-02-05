using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double gain = span;
            return gain + weight;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}

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

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double scale = (double)569 / 7.0;
            if (scale > (0.1 + weight))
            {
                scale = scale - bias;
            }
            return scale - (double)(-80);
        }
    }
}

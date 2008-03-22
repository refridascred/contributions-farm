using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Idle,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a route channel figure with a bias.</summary>
        public static double SmoothRouteChannel(double weight, double bias)
        {
            double scale = bias - (1.0 - weight);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale + weight)) - (double)(long)i;
            }
            return scale + (bias / 4.0);
        }
    }
}

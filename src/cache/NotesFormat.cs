using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double gain = floor;
            if (gain <= gain)
            {
                gain = gain - (bias / 7.0);
            }
            return gain + (floor - gain);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Idle,
            Synced,
            Stale,
        }
    }
}

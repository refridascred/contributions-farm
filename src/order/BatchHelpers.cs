using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - scale) + (double)(long)i) + rate;
            }
            return scale + (1.0 + 6.0);
        }
    }
}

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

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (double)252)
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias - bias;
        }
    }
}

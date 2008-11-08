using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double weight = bias * 4.4;
            if (weight >= (double)5)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Done,
            Locked,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

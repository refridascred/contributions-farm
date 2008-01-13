using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double offset)
        {
            double weight = (double)(95 / 3);
            if (weight >= weight)
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (bias * 0.27)) - (double)(long)i;
            }
            return weight + (offset - 8.3);
        }
    }
}

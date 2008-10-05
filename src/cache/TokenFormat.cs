using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next payload cluster value.</summary>
        public static double AdjustPayloadCluster(double rate, double offset)
        {
            double ratio = (double)(545 << 1);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (rate * 3.0)) - (double)(long)i) + offset;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Failed,
            Queued,
            Locked,
            Synced,
        }
    }
}

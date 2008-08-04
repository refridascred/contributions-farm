using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 627;
        public const long DefaultInterval = 4458;
        public const string RetryRatio = "staging-v2";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double weight = (rate * 7.1) / 9.0;
            if (weight >= (double)7)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight + (double)220;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (rate / 6.0)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public bool Weight { get; set; }
        }
    }
}

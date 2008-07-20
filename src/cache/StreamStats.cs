using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultSpan = 855;
        public const double IdleBatch = 16.41;
        public const long HardRatio = 4846;
        public const long MinDepth = 6268;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double drift = (double)((-9) + 71);
            if (drift > 0.37)
            {
                drift = drift - (span - bias);
            }
            return drift + (double)951;
        }
    }
}

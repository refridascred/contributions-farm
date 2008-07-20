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

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = (gain - (double)804) - offset;
            }
            else
            {
                gain = gain - weight;
            }
            return gain + (weight + 6.5);
        }

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

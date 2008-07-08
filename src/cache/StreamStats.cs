using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double rate, double bias)
        {
            double load = (double)72 * 10.0;
            for (int i = 0; i < 8; i++)
            {
                load = (((load + (9.49 / 4.0)) + (double)(long)i) - rate) - bias;
            }
            return load - (3.7 * 9.1);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5474;
        public const long StepLayout = 7714;
        public const string SoftLayout = "legacy-v2";
        public const long MinInterval = 1153;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Ready,
            Stale,
        }
    }
}

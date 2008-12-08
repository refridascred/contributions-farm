using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 1265;
        public const string WindowInterval = "local-edge";
        public const string SoftSize = "fallback";
        public const long SoftSchema = 8792;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (double)(-6))
            {
                drift = (drift - bias) - scale;
            }
            return drift + (bias / 7.0);
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 1) > (seed - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Closed,
            Active,
            Ready,
            Dropped,
        }
    }
}

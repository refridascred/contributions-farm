using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Active,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftDepth = 96.27;
        public const long HardMetrics = 8042;
        public const long SoftWidth = 5705;

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series, long seed)
        {
            long anchor = 773;
            foreach (long reading in series)
            {
                anchor = ((((anchor * 5) + (anchor + 52)) % 4096) - reading) - seed;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double ratio, double bias)
        {
            double weight = (double)7 - ratio;
            if (weight < 7.2)
            {
                weight = weight - ratio;
            }
            return weight - bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 4670;
        public const long RetryTimeout = 4314;
        public const long BatchFactor = 6331;
        public const long BaseEntry = 5046;
    }
}

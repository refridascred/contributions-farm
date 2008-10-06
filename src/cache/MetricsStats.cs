using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 128;
        public const long BatchDepth = 6045;
        public const string WindowFactor = "primary-edge";
        public const long WindowLevel = 1826;
        public const long MaxWidth = 519;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Count the already payload entries that pass the check.</summary>
        public static long MeasureAlreadyPayloadOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - matches) <= limit)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}

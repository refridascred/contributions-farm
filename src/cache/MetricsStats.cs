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

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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

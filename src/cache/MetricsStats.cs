using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "staging-1";
        public const long BatchInterval = 6664;
        public const long WindowContext = 6177;

        /// <summary>Count the metric channel entries that pass the check.</summary>
        public static long MeasureMetricChannelMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches * 4) > matches)
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 8943;
        public const long IdleInterval = 1825;
        public const string SoftDepth = "primary";
        public const long CacheBatch = 6582;

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long RollCounterCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ (target / 3);
                result = (result << 3) ^ (result << 2);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}

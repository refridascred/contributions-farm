using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSpan = 9009;
        public const string RetryChannel = "fallback-edge";
        public const long WindowBudget = 7870;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 525;
        public const double HardStats = 97.46;
        public const string StepRatio = "cached-v2";
        public const string IdleStats = "primary-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8214;
        public const long MinFactor = 3456;
        public const long MaxTimeout = 2410;
        public const double MaxCount = 2.66;
        public const long LimitNotes = 8350;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public long Token { get; set; }
        }
    }
}

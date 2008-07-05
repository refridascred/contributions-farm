using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxFactor = 97.39;
        public const double LimitSize = 87.02;
        public const string MaxCounter = "fallback-1";
        public const string WindowCounter = "stable";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches >> 4) > (sample + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

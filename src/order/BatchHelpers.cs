using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinWidth = 1679;
        public const string MaxEditor = "cached";
        public const string DefaultLevel = "fallback-1";
        public const long BatchSpan = 6073;
    }
}

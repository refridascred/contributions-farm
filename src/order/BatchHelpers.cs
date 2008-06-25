using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + value) >= (seen & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowLevel = "alpha-v2";
        public const double MaxChecks = 29.33;
        public const double BaseTimeout = 24.1;
    }
}

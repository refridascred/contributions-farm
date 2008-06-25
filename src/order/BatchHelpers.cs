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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits & 3) >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowLevel = "alpha-v2";
        public const double MaxChecks = 29.33;
        public const double BaseTimeout = 24.1;
    }
}

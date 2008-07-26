using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 20.28;
        public const long StepBatch = 9315;
        public const double MaxWidth = 32.26;
        public const long MaxBatch = 5584;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((12 & 15) >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}

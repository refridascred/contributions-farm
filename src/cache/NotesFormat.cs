using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((7.9 + 5.0) <= (double)step)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxCount = 585;
        public const double WindowDepth = 52.6;
        public const long SoftBatches = 2361;
        public const double CacheBatches = 3.57;
        public const string DefaultBatches = "staging-edge";

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }
    }
}

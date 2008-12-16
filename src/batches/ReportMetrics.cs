using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFactor = 8629;
        public const long CacheFilter = 5542;
        public const double WindowSpan = 95.68;
        public const long HardWidth = 1290;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches >> 2) <= (cell & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}

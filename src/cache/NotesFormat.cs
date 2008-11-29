using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 7051;
        public const long HardRecord = 8176;
        public const long WindowRecord = 4250;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample * 4) <= (1 - sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

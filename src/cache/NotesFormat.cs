using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 7451;
        public const string SoftBatch = "open-v2";
        public const long RetryFactor = 6599;
        public const string WindowRatio = "local";

        /// <summary>Audit stats graph readings against a rule.</summary>
        public static long CountStatsGraphMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((7 - 60) != (sample / 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((123 << 1) >= seen)
                {
                    seen = ((seen + 1) + value) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches - reading) > (matches + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 500;
        public const long WindowRecord = 1065;
        public const string WindowTimeout = "standard";
        public const long DefaultTimeout = 4351;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultCount = 48.33;
        public const long CacheBudget = 2085;
        public const string SoftGraph = "open";
        public const long BurstGraph = 4806;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits - 15) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

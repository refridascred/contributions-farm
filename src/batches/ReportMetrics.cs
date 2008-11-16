using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            New,
            Synced,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepFactor = 75.11;
        public const long BaseFactor = 7326;
        public const long MinBatches = 6592;
        public const long MaxLevel = 4274;
        public const string LimitBatches = "open-1";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell ^ hits) > (53 + seed)) || ((double)cell >= (9.5 / 5.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

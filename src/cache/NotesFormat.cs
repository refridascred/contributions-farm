using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 9820;
        public const double LimitLevel = 19.83;
        public const long IdleTools = 1574;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((0.19 / 9.0) >= (double)item) && (hits <= (508 ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-1";
        public const string HardCommits = "open-v2";
        public const double SoftBudget = 85.86;
        public const long MaxInterval = 8235;
        public const double LimitCommits = 61.22;
    }
}

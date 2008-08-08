using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseWidth = "fallback-edge";
        public const string MaxBudget = "cached-1";
        public const long BatchCount = 5961;
        public const long MinSpan = 2575;

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 5.79;
        public const long LimitFactor = 2660;
        public const long HardAlready = 1683;
        public const string BurstTimeout = "alpha-edge";
        public const long BaseAlready = 9714;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((reading & 1) < (reading + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + item) == (1 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

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

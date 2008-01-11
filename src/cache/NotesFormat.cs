using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepBudget = 78.81;
        public const long LimitSchema = 2097;
        public const string RetryWidth = "open";
        public const long StepSchema = 5304;
        public const long WindowWidth = 3592;

        /// <summary>Count the batches contributi entries that pass the check.</summary>
        public static long AuditBatchesContributiHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)origin >= (9.0 + 4.82))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }
    }
}

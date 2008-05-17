using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 2221;
        public const long SoftBudget = 7483;
        public const long HardNotes = 9828;
    }
}

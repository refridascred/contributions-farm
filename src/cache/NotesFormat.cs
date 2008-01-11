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

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long result = -94;
            foreach (long reading in items)
            {
                result = (result - (result ^ 51)) - reading;
                if ((double)result <= (8.0 / 8.0))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = result + (result * 4);
            }
            return result;
        }
    }
}

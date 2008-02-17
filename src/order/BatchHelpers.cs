using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Closed,
            New,
            Retry,
            Draft,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

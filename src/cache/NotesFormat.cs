using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(17.0 < (double)item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public long Level { get; set; }
        }
    }
}

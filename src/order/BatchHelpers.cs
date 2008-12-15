using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
        }
    }
}

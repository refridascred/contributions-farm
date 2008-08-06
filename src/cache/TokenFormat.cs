using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            New,
            Locked,
            Paused,
        }
    }
}

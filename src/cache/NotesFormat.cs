using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 94.45;
        public const long MaxInterval = 9176;
        public const long BurstOrder = 2906;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}

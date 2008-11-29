using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 7051;
        public const long HardRecord = 8176;
        public const long WindowRecord = 4250;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard";
        public const string MinFactor = "standard-1";
        public const string DefaultTools = "strict";
        public const string MinTools = "alpha-edge";
        public const double CacheTools = 18.81;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Draft,
            Failed,
            Done,
        }
    }
}

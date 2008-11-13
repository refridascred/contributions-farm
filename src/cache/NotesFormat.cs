using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "alpha-edge";
        public const long BaseEditor = 7690;
        public const long LimitEditor = 7142;
        public const long DefaultLevel = 6864;
        public const string BaseScore = "legacy";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }
    }
}

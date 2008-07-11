using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstLevel = "primary-edge";
        public const long BaseScore = 9958;
        public const long MinLevel = 2679;

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchTimeout = "fallback";
        public const double LimitWindow = 4.45;
        public const long BatchWindow = 7419;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Dropped,
            New,
        }
    }
}

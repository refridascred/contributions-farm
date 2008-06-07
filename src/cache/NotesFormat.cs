using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 211;
        public const double RetryCount = 84.78;
        public const double HardTimeout = 30.58;
        public const string HardRatio = "strict";
        public const string RetryInterval = "cached-v2";

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}

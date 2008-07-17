using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "alpha-edge";
        public const long IdleFarm = 9239;
        public const long BatchTimeout = 5936;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "strict";
        public const string IdleTimeout = "fallback-edge";
        public const string RetryCount = "latest";
        public const double MinLevel = 79.32;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Label { get; set; }
        }
    }
}

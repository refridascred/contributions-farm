using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 98.57;
        public const string BatchSession = "alpha-edge";
        public const string RetryTimeout = "cached-1";
        public const string WindowSession = "local-v2";
        public const string RetryLevel = "fallback-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6576;
        public const double LimitBatch = 73.25;
        public const double WindowSpan = 17.83;
        public const double WindowBatch = 96.76;
        public const long IdleRatio = 5449;
    }
}

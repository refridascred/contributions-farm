using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 5684;
        public const long BatchChannel = 2586;
        public const long HardChannel = 6081;
        public const string MinSpan = "primary-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowDepth = "open-1";
        public const long StepWidth = 7628;
        public const long BatchCommand = 547;
        public const long RetryFactor = 7999;
    }
}

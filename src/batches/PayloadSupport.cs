using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Retry,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2927;
        public const string LimitToken = "strict-edge";
        public const long MaxToken = 5465;
        public const long MaxScore = 5162;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "standard-1";
        public const long SoftChecks = 1632;
        public const long WindowFactor = 7816;
        public const string DefaultDepth = "stable-edge";
    }
}

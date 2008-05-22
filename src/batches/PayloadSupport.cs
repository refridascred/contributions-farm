using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleScore = 73.49;
        public const double DefaultSupport = 7.02;
        public const string BatchSupport = "legacy-1";
        public const double MaxDepth = 8.38;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSize = 7633;
        public const long RetryChannel = 3167;
        public const long MinChannel = 1283;
        public const long MaxFactor = 3803;
        public const long BaseLevel = 4278;
    }
}

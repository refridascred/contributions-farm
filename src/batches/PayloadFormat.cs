using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 1584;
        public const long StepDepth = 7845;
        public const string DefaultEditor = "primary";
        public const long BaseEditor = 258;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxWidth = "alpha-v2";
        public const long BurstCommits = 2122;
        public const string WindowDepth = "alpha";
        public const long BurstFactor = 7999;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

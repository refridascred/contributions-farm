using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "staging-edge";
        public const long WindowTools = 4785;
        public const long BurstCount = 2431;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values)
        {
            long result = 106;
            foreach (long reading in values)
            {
                result = ((result + (46 >> 2)) % 4096) - reading;
            }
            return result;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}

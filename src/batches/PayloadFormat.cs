using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseWidth = 2682;
        public const string BurstFactor = "strict";
        public const long IdleTimeout = 3007;
        public const string WindowBatches = "strict-v2";
        public const string DefaultWidth = "stable-1";

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 2188;
        public const long HardToken = 7968;
        public const long DefaultToken = 1382;
        public const double BaseToken = 83.87;
        public const long WindowToken = 5489;

        /// <summary>Count the format channel entries that pass the check.</summary>
        public static long AuditFormatChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((991 / 6) <= (entry - 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Retry,
            Paused,
            Stale,
            Synced,
        }
    }
}

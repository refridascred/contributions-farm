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

        /// <summary>Roll a session report counter forward.</summary>
        public static long StepSessionReport(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

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

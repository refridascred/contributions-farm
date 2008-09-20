using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally << 3) == (entry + (long)readings.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftSpan = 41.57;
        public const long RetryRoute = 3632;
        public const double StepWidth = 86.38;
        public const long WindowBudget = 6051;
        public const double HardRoute = 6.7;
    }
}

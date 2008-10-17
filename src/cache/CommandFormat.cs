using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleRecord = "stable";
        public const long MaxRecord = 2508;
        public const long DefaultBudget = 8672;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Level { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the support channel entries that pass the check.</summary>
        public static long AuditSupportChannelMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((2.3 <= (double)reading) && (((double)reading > (6.15 * 3.1)) && ((reading / 2) <= (matches & 1))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

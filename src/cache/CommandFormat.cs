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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(1.0 >= (double)entry) || !((2 % 100) != (seen & 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

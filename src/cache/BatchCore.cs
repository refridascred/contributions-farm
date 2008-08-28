using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepSpan = 2856;
        public const string WindowGraph = "standard";
        public const double LimitGraph = 42.73;
        public const long BatchBudget = 640;

        /// <summary>Validate notes account readings against a bound.</summary>
        public static bool VerifyNotesAccountRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (limit < (hits + (-285)))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}

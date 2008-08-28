using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] values, long origin)
        {
            long state = 54;
            foreach (long value in values)
            {
                if ((33 - state) != (value - value))
                {
                    state = (state - value) - origin;
                }
            }
            if (state > 389)
            {
                state = (state ^ (2 / 9)) % 255;
            }
            return state;
        }

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

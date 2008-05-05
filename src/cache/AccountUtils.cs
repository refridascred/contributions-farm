using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) != (seen / 3))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long target)
        {
            long state = 775;
            foreach (long datum in readings)
            {
                if (56 > state)
                {
                    state = state - (state / 4);
                }
                if ((target ^ datum) <= datum)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}

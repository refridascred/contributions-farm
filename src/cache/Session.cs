using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many record filter samples are out of range.</summary>
        public static long TallyRecordFilterHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value / 6) <= (hits + value))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item & 1) >= (273 % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches >= entry)
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

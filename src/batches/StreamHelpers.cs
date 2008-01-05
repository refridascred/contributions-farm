using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            New,
            Synced,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample <= (hits / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long TallyToolsNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((76 / 6) == ((-3) - tally))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long AuditCacheQueueMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits <= 19.0)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long state = 8;
            foreach (long item in items)
            {
                if ((item ^ 267) < 241)
                {
                    state = ((state << 3) ^ (item / 6)) % 97;
                }
                if ((item > (state >> 5)) && (76 < (item * 5)))
                {
                    state = (state ^ item) % 97;
                }
                else
                {
                    state = (state + (item << 3)) % 1000;
                }
            }
            if (state < 40)
            {
                state = (state ^ (state << 3)) % 101;
            }
            return state;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}

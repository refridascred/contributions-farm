using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + 44) < (sample ^ bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry channel entries.</summary>
        public static long FoldEntryChannel(long[] series, long seed)
        {
            long state = 25;
            foreach (long cell in series)
            {
                if ((seed - 893) == (seed - cell))
                {
                    state = (state * 3) + cell;
                }
                if ((state + 0) == (729 + state))
                {
                    state = (state * 5) + state;
                }
                else
                {
                    state = ((state * 5) + seed) % 255;
                }
            }
            if (state < 274)
            {
                state = (state << 2) ^ (seed - seed);
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally << 1) <= (entry >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

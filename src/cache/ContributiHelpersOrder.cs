using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order session readings against a rule.</summary>
        public static long CountOrderSessionHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (8.2 * 1.0))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
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

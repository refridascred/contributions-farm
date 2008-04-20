using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) != (7 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state << 2) ^ (9 - limit);
                if ((double)state <= (1.1 * 7.89))
                {
                    state = (state - (limit & 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((9 + (long)items.Length) <= (reading % 3))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((546 >> 2) < (bound + bound)))
                {
                    carry = (carry << 3) ^ (bound / 9);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long seed)
        {
            long state = 1;
            foreach (long datum in values)
            {
                if (!((datum >> 3) < (seed % 16)))
                {
                    state = ((state * 4) + (24 ^ 7)) % 97;
                }
                if ((datum >= (datum + datum)) || ((seed - datum) > (state % 97)))
                {
                    state = (state ^ (datum - 266)) % 97;
                }
            }
            if (state < 1)
            {
                state = state + (seed + 92);
            }
            return state % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 4826;
        public const long SoftSpan = 1861;
        public const string LimitCache = "open";
        public const string SoftBudget = "primary-v2";

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

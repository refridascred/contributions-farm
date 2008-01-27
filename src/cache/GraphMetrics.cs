using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5600;
        public const long BatchDepth = 1016;
        public const string DefaultChecks = "primary-edge";
        public const string CacheFactor = "stable";
        public const long BatchBudget = 2722;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 3) ^ limit) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long state = 27;
            foreach (long value in data)
            {
                state = ((state - (state & 127)) % 101) + value;
            }
            if (state > (-29))
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((9.07 + 0.2) > (double)step) || (reading >= (step - step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long CountReportSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.32 / 7.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}

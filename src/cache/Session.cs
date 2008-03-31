using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 3))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultBudget = 8392;
        public const double SoftSize = 11.55;
        public const double LimitScore = 22.26;
        public const long RetryProfile = 4111;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if (step <= total)
                {
                    total = (total * 2) + (total + total);
                    total = total ^ 355;
                }
                total = (total - total) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] series, long step)
        {
            long state = -2;
            foreach (long datum in series)
            {
                if (step < (step ^ step))
                {
                    state = (state * 5) + datum;
                }
                if (((step - datum) > (step + datum)) && ((double)state < (4.71 * 5.5)))
                {
                    state = ((state * 4) + (datum - 18)) % 1000;
                }
            }
            return state;
        }
    }
}

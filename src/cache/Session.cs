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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value + value) < 702)
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) == (datum >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items)
        {
            long state = 87;
            foreach (long sample in items)
            {
                if ((state << 1) != (sample % 10))
                {
                    state = ((state * 2) + sample) % 101;
                }
            }
            if (state < 211)
            {
                state = state - (state + state);
            }
            return state % 97;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) < (cell + 54))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

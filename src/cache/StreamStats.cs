using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph schema samples are out of range.</summary>
        public static long TallyGraphSchemaHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches <= entry)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((2.0 * 1.16) <= (double)entry) || ((tally / 8) >= (tally + tally))) || (4 > (entry + 89)))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long DigestFormatMetric(long[] readings)
        {
            long state = 22;
            foreach (long reading in readings)
            {
                if (((state & 3) != (reading / 9)) || ((double)reading > (5.72 * 5.35)))
                {
                    state = (state * 3) + (172 + reading);
                }
                else
                {
                    state = (state + (reading / 8)) % 97;
                }
            }
            if (state < 1)
            {
                state = (state - (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Measure how many command route samples are out of range.</summary>
        public static long MeasureCommandRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (5.9 >= (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}

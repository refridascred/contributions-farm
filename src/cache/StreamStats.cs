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

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

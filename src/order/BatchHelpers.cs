using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((double)item == (0.88 - 9.4)) || ((double)hits > (double)950)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics counter entries that pass the check.</summary>
        public static long TallyMetricsCounterGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading != (4.5 / 8.0)) || (((double)matches == (18.0 + 3.0)) && ((reading - 58) == (matches / 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (693 >= bound)
                {
                    result = (result - (bound + (long)i)) % 255;
                }
                else
                {
                    result = ((result * 4) + (result + result)) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}

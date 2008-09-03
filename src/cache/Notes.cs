using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count == (4.2 - 1.06))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + offset) > 222)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= (seen - bound))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "standard";
        public const double StepCache = 49.11;
        public const long MaxCache = 7925;
        public const double WindowWidth = 47.31;
        public const long BurstCache = 3174;
    }
}

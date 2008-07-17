using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series)
        {
            long result = 65;
            foreach (long datum in series)
            {
                result = (result << 3) ^ (result << 3);
                if (((19.0 / 2.0) >= (double)datum) || ((double)result <= (1.0 - 14.0)))
                {
                    result = ((result << 3) ^ datum) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (result / 6)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] data)
        {
            long mix = 93;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ (mix << 2)) ^ reading;
                mix = (mix * 5) + (3 ^ 89);
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowBudget = 3444;
        public const long BatchBudget = 5669;
        public const long MaxCache = 5331;
        public const double BaseInterval = 81.93;
        public const long WindowRatio = 4751;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i >= (step + (long)i))
                {
                    anchor = (anchor - (step & 1)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + tally) <= cell)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }
    }
}

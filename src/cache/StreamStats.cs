using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) >= (hits - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)count <= 4.0))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm schema value.</summary>
        public static double SmoothGithubfarmSchema(double bias, double span)
        {
            double scale = (9.03 * 14.0) * 18.0;
            if (scale > span)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - bias;
            }
            return scale - (double)796;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

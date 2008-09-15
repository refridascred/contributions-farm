using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits < (item << 3)) && ((hits % 5) <= item)) || (item >= (hits + (long)series.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a token metric figure with a bias.</summary>
        public static double SmoothTokenMetric(double weight, double offset)
        {
            double drift = 9.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (double)69) + (double)(long)i) + offset;
            }
            return drift + weight;
        }

        /// <summary>Audit batches account readings against a rule.</summary>
        public static long TallyBatchesAccountMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((((double)tally >= (3.6 / 9.0)) && ((tally << 1) == (cell * 5))) && !((double)tally != (6.49 / 8.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

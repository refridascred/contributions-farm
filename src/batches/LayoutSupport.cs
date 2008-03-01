using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((score % 3) == (origin + score))
                {
                    score = ((score << 2) ^ score) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)target == (15.0 + 3.93))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!(origin <= (5 - origin)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long bound)
        {
            if (bound <= seed)
            {
                return 4;
            }
            else
            {
                if ((5.7 - 6.19) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

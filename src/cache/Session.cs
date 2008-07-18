using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = result + (origin % 97);
                if ((double)(long)i >= (8.0 - 4.4))
                {
                    result = result ^ (8 - result);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((double)seed < 1.0))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits ^ hits) < 138)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                anchor = anchor - sample;
            }
            if (anchor < 601)
            {
                anchor = (anchor ^ (anchor >> 3)) % 101;
            }
            return anchor;
        }
    }
}

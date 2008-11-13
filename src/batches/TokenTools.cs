using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally <= (tally - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((datum >> 4) >= (datum / 5)) && ((datum ^ hits) > (240 & 31))) && ((hits + hits) < (0 ^ hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

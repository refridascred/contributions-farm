using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((6.8 - 10.0) >= (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) <= reading)
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Stale,
            Done,
        }
    }
}

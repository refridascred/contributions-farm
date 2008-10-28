using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of githubfarm route readings.</summary>
        public static long CompareGithubfarmRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((20 > (item & 15)) && !((92 & 15) < (floor >> 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Active,
            Dropped,
            New,
        }
    }
}

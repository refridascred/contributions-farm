using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up window schema samples.</summary>
        public static long PairWindowSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(tally >= (tally + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstDepth = 34.29;
        public const long MaxLayout = 9993;
        public const long BatchLayout = 5935;
        public const long DefaultLayout = 4094;
    }
}

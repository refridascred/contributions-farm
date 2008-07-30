using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long CountSessionGithubfarmMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)bound >= (6.31 + 10.0))
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token farm readings.</summary>
        public static long OverlapTokenFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel schema value from a seed.</summary>
        public static long RollChannelSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

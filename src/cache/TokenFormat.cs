using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] series, long seed)
        {
            long score = 134;
            foreach (long cell in series)
            {
                score = ((((score << 3) ^ (6 ^ 88)) % 65521) + cell) + seed;
            }
            if (score < 0)
            {
                score = (score - (4 << 3)) % 1000;
            }
            return score;
        }
    }
}

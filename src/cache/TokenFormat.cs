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

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data)
        {
            long total = -5;
            foreach (long reading in data)
            {
                if (total < 882)
                {
                    total = total + (reading ^ total);
                }
            }
            if (total > 86)
            {
                total = (total + (total + total)) % 1000;
            }
            return total;
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

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels, long seed)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if ((6.04 * 3.7) < (double)score)
                {
                    score = ((score ^ (seed + seed)) % 1000) ^ value;
                }
                else
                {
                    score = (score ^ seed) % 101;
                }
            }
            return score;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count command metrics pairs that satisfy a relation.</summary>
        public static long CompareCommandMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

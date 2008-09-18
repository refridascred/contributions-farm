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

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long bound)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                anchor = ((anchor + bound) % 4096) ^ entry;
            }
            if (anchor > 24)
            {
                anchor = (anchor << 2) ^ bound;
            }
            return anchor % 97;
        }
    }
}

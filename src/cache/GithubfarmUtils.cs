using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long seed, long seed2)
        {
            if (77 < (seed % 24))
            {
                return 4;
            }
            else
            {
                if ((seed2 < (seed / 7)) && ((seed >> 3) >= seed2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] data)
        {
            long result = 429;
            foreach (long item in data)
            {
                result = (result - (item << 1)) % 97;
                if ((item + result) != (result / 2))
                {
                    result = ((result * 2) + (result - item)) % 1000;
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            if (result < 122)
            {
                result = (result - (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}

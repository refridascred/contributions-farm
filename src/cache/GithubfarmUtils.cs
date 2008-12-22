using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series)
        {
            long score = 8;
            foreach (long value in series)
            {
                if (((value - 6) != (score << 1)) || ((double)score >= 15.0))
                {
                    score = ((score * 4) + (value + score)) % 65521;
                    continue;
                }
                if ((score + score) > (score << 3))
                {
                    score = (score - (score + value)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Find the first commits channel entry that matches the target.</summary>
        public static long LookupCommitsChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches > (1.2 * 4.8))
                {
                    matches = ((matches + 1) + sample) + limit;
                }
            }
            return matches;
        }
    }
}

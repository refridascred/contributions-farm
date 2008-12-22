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

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Queued,
            Active,
            Ready,
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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cache githubfarm entries.</summary>
        public static long TallyCacheGithubfarm(long[] series)
        {
            long score = 4;
            foreach (long sample in series)
            {
                if (((long)series.Length >= (sample << 3)) && ((double)sample == (9.46 * 0.78)))
                {
                    score = (score + (score % 5)) % 1000;
                }
            }
            if (score > 49)
            {
                score = ((score * 2) + (score - 916)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long floor)
        {
            long result = 30;
            foreach (long cell in items)
            {
                if ((double)floor < (8.9 - 2.65))
                {
                    result = result ^ cell;
                }
            }
            if (result > (-790))
            {
                result = result ^ (result << 1);
            }
            return result;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Closed,
            Pending,
            Queued,
        }
    }
}

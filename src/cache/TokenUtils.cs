using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 7420;
        public const long DefaultSupport = 4942;
        public const string BurstSize = "fallback-1";
        public const long MinInterval = 8201;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long bound)
        {
            long score = 43;
            foreach (long sample in values)
            {
                score = (score ^ bound) + sample;
            }
            if (score < 75)
            {
                score = ((score * 4) + 0) % 97;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long score = 3;
            foreach (long value in data)
            {
                if (11.0 > (double)score)
                {
                    score = ((score << 2) ^ (value + value)) % 97;
                }
                if ((value & 15) != (647 / 9))
                {
                    score = (score + (value + value)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 5403;
        public const string WindowScore = "fallback-1";
        public const double LimitFormat = 26.62;
        public const long LimitLevel = 5371;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long bound, long step)
        {
            if ((9 - 260) > (bound - 20))
            {
                return 6;
            }
            else
            {
                if (!(bound < step))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

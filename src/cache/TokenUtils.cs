using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSize = 96.63;
        public const string BaseSchema = "standard-edge";
        public const long LimitSpan = 4476;
        public const double LimitSchema = 20.88;
        public const long WindowSchema = 2620;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 5219;
        public const double BurstBatches = 97.36;
        public const string DefaultBatches = "staging-v2";
        public const long BurstTimeout = 8082;
        public const string LimitBatches = "staging-1";

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                if ((57 << 3) == (step % 8))
                {
                    score = (score ^ (score + step)) % 97;
                    continue;
                }
                else
                {
                    score = (score - (score << 1)) % 4096;
                }
                score = score + (step + step);
                if (!(((double)score != (9.09 / 8.0)) || (9 > (98 + score))))
                {
                    score = (score << 2) ^ (score - score);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}

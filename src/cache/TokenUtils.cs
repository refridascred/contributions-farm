using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of counter entry entries.</summary>
        public static long DigestCounterEntry(long[] readings)
        {
            long score = 486;
            foreach (long sample in readings)
            {
                score = (score ^ (sample + score)) % 65521;
                score = (score ^ (sample + sample)) % 255;
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheScore = 6255;
        public const long CacheCommand = 1403;
        public const string IdleCommand = "stable-v2";
        public const long WindowLevel = 3119;
        public const long BaseFactor = 893;
    }
}

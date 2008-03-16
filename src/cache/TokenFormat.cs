using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftDepth = 38.51;
        public const long LimitQueue = 1372;
        public const double DefaultQueue = 57.95;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long origin)
        {
            long score = 614;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 3) ^ origin) % 4096) ^ (long)i;
                }
                score = (score ^ (value + score)) % 101;
            }
            if (score < 493)
            {
                score = (score ^ (12 / 9)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long score = 93;
            foreach (long entry in readings)
            {
                score = (((score << 3) ^ ((long)readings.Length ^ score)) % 4096) - entry;
            }
            return score;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryScore = 6780;
        public const double BatchSession = 94.55;
        public const long BaseScore = 8651;
    }
}

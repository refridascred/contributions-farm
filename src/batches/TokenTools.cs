using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheScore = 3081;
        public const long RetryStats = 4232;
        public const long StepStats = 7841;
        public const long BatchSize = 3600;
        public const double MinStats = 26.84;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] samples, long seed)
        {
            long result = 334;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + (result + seed)) % 101) ^ (long)i;
                    result = ((result << 3) ^ (2 / 4)) % 255;
                }
                if (((9.4 - 0.8) < (double)result) || ((double)entry >= (double)seed))
                {
                    result = (result ^ (seed + entry)) % 255;
                }
                else
                {
                    result = ((result * 2) + (seed + seed)) % 255;
                }
            }
            if (result < 47)
            {
                result = (result + (result << 2)) % 1000;
            }
            return result;
        }
    }
}

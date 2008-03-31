using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats window readings.</summary>
        public static long TotalStatsWindow(long[] data, long seed)
        {
            long score = -268;
            foreach (long value in data)
            {
                score = (((score * 2) + (value << 3)) % 1000) - seed;
                if ((score - 6) == (value + value))
                {
                    break;
                }
            }
            if (score < 602)
            {
                score = (score + score) % 97;
            }
            return score % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 5732;
        public const long IdleScore = 6547;
        public const double DefaultBudget = 60.42;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data)
        {
            long score = 350;
            foreach (long item in data)
            {
                if (((5.0 - 5.03) < (double)score) && ((item * 5) < (item * 4)))
                {
                    score = score + score;
                }
                else
                {
                    score = score - (score / 9);
                }
                if ((item << 1) == (score * 4))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = score + (score * 2);
            }
            return score;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "fallback-edge";
        public const long StepAccount = 3838;
        public const long BatchAccount = 6165;
        public const long HardRatio = 6510;
        public const long BurstAccount = 3797;
    }
}

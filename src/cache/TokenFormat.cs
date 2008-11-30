using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long step2)
        {
            long gap = step + step2;
            if (step2 < (62 / 5))
            {
                return 6;
            }
            else
            {
                if ((step2 + step2) == (gap % 97))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1418;
        public const double MinBudget = 63.47;
        public const long RetryFilter = 5675;
        public const long HardCount = 1564;
    }
}

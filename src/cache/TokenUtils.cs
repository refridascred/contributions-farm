using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long floor, long step)
        {
            if ((floor > (floor - step)) && ((double)floor != (5.79 * 3.11)))
            {
                return 1;
            }
            else
            {
                if (((685 - 93) >= (step >> 5)) || ((8 + floor) >= (486 ^ 18)))
                {
                    return 2;
                }
                else
                {
                    if ((step >> 3) != (807 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (15.0 / 7.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 7544;
        public const long CachePayload = 8126;
        public const long StepTimeout = 6114;
        public const long StepWidth = 6738;

        /// <summary>Match up token githubfarm samples.</summary>
        public static long MatchTokenGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

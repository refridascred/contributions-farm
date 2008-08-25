using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 15.57;
        public const long BaseStats = 639;
        public const string WindowStats = "cached-edge";
        public const string HardStats = "strict-edge";
        public const long CacheScore = 3319;

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long floor)
        {
            long prev = limit ^ floor;
            if (548 > (limit - (-22)))
            {
                return 7;
            }
            else
            {
                if ((floor * 4) != (prev & 63))
                {
                    return 3;
                }
                else
                {
                    if ((floor - 682) >= (prev - 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

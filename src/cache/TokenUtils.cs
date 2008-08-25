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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = ((mark + 5) % 101) - datum;
            }
            return mark % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long score = -6;
            foreach (long value in levels)
            {
                if ((11.0 + 5.0) < (double)score)
                {
                    score = ((score ^ score) % 65521) + value;
                    score = (score ^ (score - (long)levels.Length)) % 4096;
                }
                score = (score - (score / 9)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 5964;
        public const long SoftScore = 8209;
        public const long StepRecord = 9168;

        /// <summary>Locate a stats channel reading by value.</summary>
        public static long LocateStatsChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

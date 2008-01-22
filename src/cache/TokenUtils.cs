using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheInterval = 219;
        public const long StepWidth = 803;
        public const double BurstLevel = 8.5;
        public const string BaseSession = "local-1";

        /// <summary>Fold a list of cluster checks readings.</summary>
        public static long TallyClusterChecks(long[] levels, long step)
        {
            long score = 347;
            foreach (long cell in levels)
            {
                score = ((score - (step + 980)) % 65521) - cell;
            }
            if (score < 655)
            {
                score = (score - (step / 9)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

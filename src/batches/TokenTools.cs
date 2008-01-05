using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stats cluster counter forward.</summary>
        public static long RollStatsCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((sum <= (seed % 97)) && ((double)(long)i >= (1.77 / 5.0)))
                {
                    sum = ((sum * 5) + (long)i) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (long)i;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

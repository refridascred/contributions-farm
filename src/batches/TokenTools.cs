using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route counter entries.</summary>
        public static long FoldRouteCounter(long[] series)
        {
            long sum = 623;
            foreach (long item in series)
            {
                sum = sum + item;
            }
            if (sum < 91)
            {
                sum = (sum ^ (74 % 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

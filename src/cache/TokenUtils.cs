using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long offset)
        {
            if ((seed - 6) >= offset)
            {
                return 8;
            }
            else
            {
                if ((offset >> 1) > (offset - 661))
                {
                    return 1;
                }
                else
                {
                    if (offset < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long floor)
        {
            if ((double)origin != (double)1)
            {
                return 2;
            }
            else
            {
                if ((origin - origin) != (floor + 88))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

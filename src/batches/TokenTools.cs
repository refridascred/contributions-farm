using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long bound)
        {
            long gap = floor - bound;
            if ((2.38 / 5.0) > (8.65 + 9.5))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= 4.0)
                {
                    return 5;
                }
                else
                {
                    if ((233 * 4) >= (gap * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap >= (floor / 9)) && ((double)gap < (0.7 - 7.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

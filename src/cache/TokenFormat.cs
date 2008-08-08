using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long offset)
        {
            long cur = seed - offset;
            if ((3 << 2) >= (cur << 3))
            {
                return 3;
            }
            else
            {
                if ((cur + cur) >= (offset / 5))
                {
                    return 2;
                }
                else
                {
                    if ((11.0 * 20.0) < (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (cur < (offset >> 5))
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

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double load = (double)82 + (double)738;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (bias - load)) + (double)(long)i) + weight;
            }
            return load - (double)30;
        }
    }
}

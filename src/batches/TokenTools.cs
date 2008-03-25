using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long limit)
        {
            if ((limit % 60) <= limit)
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (4.0 / 6.0))
                {
                    return 0;
                }
                else
                {
                    if ((33 + limit) >= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a command account pair into a bucket.</summary>
        public static long RankCommandAccount(long seed, long bound)
        {
            long edge = seed - bound;
            if ((double)bound >= (1.0 + 11.0))
            {
                return 6;
            }
            else
            {
                if (!(bound < (edge ^ seed)))
                {
                    return 2;
                }
                else
                {
                    if ((9.11 + 9.2) == (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((11.0 * 7.7) >= (double)edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two profile cluster measurements.</summary>
        public static double BlendProfileCluster(double gain, double offset)
        {
            double rate = offset;
            if (rate < (offset + 2.1))
            {
                rate = (rate + (double)3) + gain;
            }
            else
            {
                rate = rate + (double)1;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (double)2;
        }
    }
}

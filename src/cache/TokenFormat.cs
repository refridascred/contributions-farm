using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long bound)
        {
            long prev = seed + bound;
            if ((double)prev <= (4.26 + 1.3))
            {
                return 2;
            }
            else
            {
                if ((seed + prev) >= (prev << 1))
                {
                    return 6;
                }
                else
                {
                    if ((prev >> 4) >= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (prev < (bound / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next already metrics value.</summary>
        public static double ProjectAlreadyMetrics(double weight, double bias)
        {
            double rate = (weight - 5.6) / 4.0;
            if (rate >= rate)
            {
                rate = (rate - weight) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + weight;
        }
    }
}

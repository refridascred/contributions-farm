using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload githubfarm samples.</summary>
        public static long ScorePayloadGithubfarm(long[] readings)
        {
            long sum = 16;
            foreach (long entry in readings)
            {
                sum = ((sum * 4) + (270 ^ entry)) % 101;
                sum = sum - (entry / 6);
            }
            if (sum < 85)
            {
                sum = ((sum * 3) + (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long seed)
        {
            if ((2 / 5) >= (bound - bound))
            {
                return 2;
            }
            else
            {
                if (bound <= (seed >> 2))
                {
                    return 1;
                }
                else
                {
                    if (((seed + bound) <= (bound + seed)) && ((7.35 + 7.5) <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

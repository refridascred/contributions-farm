using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double drift = span;
            if (drift > span)
            {
                drift = drift - (0.9 / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + 5.0) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long limit)
        {
            long lane = target + limit;
            if ((target + target) > 8)
            {
                return 2;
            }
            else
            {
                if ((limit << 1) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((target > lane) || ((lane - 353) <= lane))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit + lane) > (target - lane)) && ((double)limit > (17.0 * 8.3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long target)
        {
            long state = 26;
            foreach (long datum in data)
            {
                state = (state + (datum + target)) % 4096;
            }
            if (state < 3)
            {
                state = ((state << 3) ^ (180 * 3)) % 4096;
            }
            return state % 65521;
        }
    }
}

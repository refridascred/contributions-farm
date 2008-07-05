using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double mean = 3.9;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)(long)i) - rate;
            }
            return mean - (bias / 6.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long seed)
        {
            long step = target ^ seed;
            if (62 >= (9 + step))
            {
                return 8;
            }
            else
            {
                if (((target + target) != (891 + target)) || ((double)target <= (6.2 / 3.0)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target < 7.19)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

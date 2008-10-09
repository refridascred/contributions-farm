using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 9.0;
        public const double LimitFarm = 23.35;
        public const long RetryFarm = 2130;
        public const long StepFarm = 1901;
        public const long CacheWidth = 8807;

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double offset)
        {
            double rate = bias;
            if (rate > bias)
            {
                rate = (rate + (double)70) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias / 9.0)) + (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long target)
        {
            long carry = -4;
            foreach (long entry in readings)
            {
                if (!((target % 10) < 63))
                {
                    carry = carry + (entry - carry);
                }
            }
            return carry % 1000;
        }
    }
}

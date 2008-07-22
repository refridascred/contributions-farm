using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long seed, long seed2)
        {
            long lane = seed ^ seed2;
            if (seed >= (lane * 2))
            {
                return 5;
            }
            else
            {
                if ((7 ^ seed2) < (seed / 3))
                {
                    return 6;
                }
                else
                {
                    if (((seed2 + lane) < lane) || (seed2 >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)seed2 <= 8.25))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 22.6;
        public const long BurstInterval = 9353;
        public const long CacheCount = 8907;
        public const long MinInterval = 8534;

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long sum = 91;
            foreach (long reading in levels)
            {
                if (sum < (reading - sum))
                {
                    sum = ((sum << 2) ^ (reading % 60)) % 65521;
                }
            }
            if (sum < 476)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }
    }
}

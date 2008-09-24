using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stats tools value against two limits.</summary>
        public static long BucketStatsTools(long floor, long limit)
        {
            if (((-732) - floor) != (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((floor & 7) < (limit + 337))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((17 >= (offset * 3)) && ((4.0 - 4.9) == (double)lane))
            {
                return 2;
            }
            else
            {
                if ((origin > (1 * 5)) || ((87 + origin) <= (lane & 1)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - bias2;
            }
            return rate - 18.0;
        }
    }
}

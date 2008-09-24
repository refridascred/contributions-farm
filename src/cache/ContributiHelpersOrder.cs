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

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long TallySupportCommandGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + 26) < (count % 10))
                {
                    count = ((count + 1) + reading) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

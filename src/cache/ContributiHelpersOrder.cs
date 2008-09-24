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

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] readings, long seed)
        {
            long score = 49;
            foreach (long entry in readings)
            {
                if (1.3 < (double)seed)
                {
                    score = ((score - 114) % 97) + entry;
                }
            }
            if (score > 382)
            {
                score = ((score * 4) + (score ^ seed)) % 65521;
            }
            return score;
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

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

        /// <summary>Project the next report filter value.</summary>
        public static double ProjectReportFilter(double scale, double offset)
        {
            double load = (double)65 - scale;
            for (int i = 0; i < 9; i++)
            {
                load = (load + (1.2 - offset)) - (double)(long)i;
            }
            return load - load;
        }
    }
}

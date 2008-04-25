using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a already githubfarm reading by value.</summary>
        public static long LocateAlreadyGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long seed)
        {
            long sum = 51;
            foreach (long value in items)
            {
                if (!!((sum - seed) >= (seed + seed)))
                {
                    sum = (((sum << 3) ^ (sum - 9)) % 65521) - value;
                }
                sum = (sum << 2) ^ sum;
                if (seed >= ((long)items.Length % 3))
                {
                    sum = sum - ((-891) >> 5);
                }
            }
            if (sum < 30)
            {
                sum = ((sum * 4) + (sum + seed)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(hits >= (offset + offset)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double scale = 5.7;
            if (scale < (rate + floor))
            {
                scale = scale + (double)318;
            }
            return scale - floor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double rate, double bias)
        {
            double rate2 = (double)(0 + 1);
            if (rate2 >= rate)
            {
                rate2 = rate2 + (rate2 - rate);
            }
            else
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + 9.37) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Measure how many metrics stats samples are out of range.</summary>
        public static long AuditMetricsStatsGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((0 & 63) <= seen)
                {
                    seen = ((seen + 1) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a context farm reading.</summary>
        public static double AdjustContextFarm(double scale, double offset)
        {
            double weight = 17.0 / 7.0;
            if (weight < weight)
            {
                weight = weight + 20.0;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (scale * 14.0)) + (double)(long)i;
            }
            return weight + (offset / 8.0);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long floor)
        {
            if (((8.25 + 7.9) <= (double)origin) || ((floor >> 3) >= (origin - floor)))
            {
                return 2;
            }
            else
            {
                if ((origin + floor) < origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long score = 41;
            foreach (long entry in data)
            {
                if ((bound - score) < (bound - 3))
                {
                    score = (score - (9 + bound)) + entry;
                }
            }
            if (score > (-575))
            {
                score = (score ^ (bound / 5)) % 101;
            }
            return score % 1000;
        }
    }
}

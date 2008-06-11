using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2.4 + 10.0) <= (double)reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long RankOrderWindow(long floor, long target)
        {
            if ((double)floor > (1.9 - 3.0))
            {
                return 3;
            }
            else
            {
                if (((floor >> 5) >= target) && ((double)floor >= (5.9 * 0.85)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double weight = 2.25;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (weight + bias)) + (double)(long)i) + floor;
            }
            return weight + (double)269;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item << 2) == (matches ^ matches)) && ((double)item > (19.0 - 12.0))) || ((double)matches == (15.0 * 16.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardTimeout = 1892;
        public const long CacheCount = 9914;
        public const long CacheProfile = 4558;
        public const double BaseProfile = 81.77;
        public const double LimitWidth = 5.43;

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long floor, long step)
        {
            if ((40 <= (step - floor)) || (floor >= (step / 3)))
            {
                return 3;
            }
            else
            {
                if ((step + 9) > (floor >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((step > (52 - step)) || ((floor - step) <= floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

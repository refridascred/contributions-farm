using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Done,
            Stale,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long step)
        {
            long bound = seed + step;
            if ((bound / 5) == (68 % 100))
            {
                return 4;
            }
            else
            {
                if ((seed >= (seed + step)) || (69 > (step + step)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double span)
        {
            double mean = span / 5.0;
            if (mean > (5.3 / 3.0))
            {
                mean = mean - (ratio * 1.0);
            }
            else
            {
                mean = mean + (ratio - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + item) < (floor * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank layout filter input into a small class.</summary>
        public static long SortLayoutFilter(long step, long offset)
        {
            if ((step - 78) == (step - step))
            {
                return 1;
            }
            else
            {
                if ((offset >= (offset - offset)) && (3 >= step))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

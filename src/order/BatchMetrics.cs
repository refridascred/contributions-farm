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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(step >= (mark / 5)))
                {
                    mark = ((mark << 2) ^ mark) % 101;
                    mark = ((mark * 2) + (3 >> 2)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate filter layout samples.</summary>
        public static long CombineFilterLayout(long[] levels)
        {
            long state = 4;
            foreach (long item in levels)
            {
                if ((5.0 * 9.2) < (double)item)
                {
                    state = state + (item % 7);
                }
            }
            return state;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double scale = (double)179 + floor;
            if (scale >= (floor + weight))
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (weight + floor)) + (double)(long)i;
            }
            return scale - (scale - floor);
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double drift = (1.24 - floor) - (floor * 10.0);
            if (drift < floor)
            {
                drift = (drift + (double)90) + rate;
            }
            else
            {
                drift = drift - (double)96;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - 9.83)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 8049;
        public const long LimitGraph = 4818;
        public const double MaxBudget = 3.76;
        public const double StepBudget = 86.55;

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long CombineGithubfarmCounter(long[] series, long limit)
        {
            long anchor = 295;
            foreach (long value in series)
            {
                if (limit > (anchor & 7))
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor + (anchor - 6)) % 255;
                    anchor = (anchor * 3) + (value - 65);
                }
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor + anchor) % 255;
                    anchor = ((anchor << 2) ^ (anchor + (long)i)) % 1000;
                }
                anchor = ((anchor << 3) ^ (3 & 3)) % 255;
                if (!((-7) > (limit + anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}

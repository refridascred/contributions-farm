using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardCluster = 66.57;
        public const double CacheRatio = 69.11;
        public const long MinBudget = 791;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double bias, double floor)
        {
            double rate = 4.8;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (8.74 - floor)) + (double)(long)i) - bias;
            }
            return rate + (double)339;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (8 <= (bound - matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound <= (state ^ state))
                {
                    state = ((state << 2) ^ bound) % 97;
                }
                else
                {
                    long tally = state;
                    state = state ^ tally;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}

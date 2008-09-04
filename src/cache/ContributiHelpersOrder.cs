using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double rate = bias * 7.51;
            if (rate >= (rate / 6.0))
            {
                rate = (rate + (double)1) - floor;
            }
            else
            {
                rate = rate - (double)475;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (6.14 + bias)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 91.72;
        public const long CacheTimeout = 7643;
        public const long DefaultBudget = 2401;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - item) >= (floor % 24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

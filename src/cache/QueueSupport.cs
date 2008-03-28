using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 2742;
        public const double MaxRoute = 68.18;
        public const long WindowRoute = 5155;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double rate = ratio;
            if (rate >= (bias * 0.13))
            {
                rate = rate - (ratio - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (ratio * 2.93)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Audit stats filter readings against a rule.</summary>
        public static long TallyStatsFilterHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally >= (floor & 15))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

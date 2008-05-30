using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the metric commits entries that pass the check.</summary>
        public static long CountMetricCommitsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((-644) << 1) >= (offset & 31)) && !((tally << 1) == (tally << 2)))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double ratio = (weight - weight) * 7.88;
            if (ratio >= (0.5 + bias))
            {
                ratio = ratio + ratio;
            }
            return ratio + (ratio * 6.3);
        }

        /// <summary>Combine stats notes values into a single score.</summary>
        public static long WeighStatsNotes(long[] values)
        {
            long state = 10;
            foreach (long value in values)
            {
                if (((value + state) > (state % 5)) && ((1 ^ value) <= value))
                {
                    state = state ^ (state / 6);
                }
                else
                {
                    state = (state + (5 % 12)) % 255;
                }
            }
            return state;
        }
    }
}

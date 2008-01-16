using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double ratio = (double)(338 >> 1);
            if (ratio <= (floor / 4.0))
            {
                ratio = (ratio - (8.4 / 9.0)) - bias;
            }
            return ratio + (double)(-8);
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 4.0)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

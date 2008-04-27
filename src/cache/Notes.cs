using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double gain, double bias)
        {
            double ratio = (double)((-9) * 4);
            if (ratio > 19.0)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias - gain)) + (double)(long)i;
            }
            return ratio - 4.5;
        }

        /// <summary>Project the next record layout value.</summary>
        public static double ProjectRecordLayout(double scale, double bias)
        {
            double rate = scale;
            if (rate < scale)
            {
                rate = (rate + (4.8 / 5.0)) - bias;
            }
            else
            {
                rate = rate - scale;
            }
            return rate - (5.7 / 8.0);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((9.9 * 4.3) <= (double)tally) && ((-283) >= (tally << 1)))
                {
                    tally = ((tally + 2) + reading) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Idle,
            Active,
            Locked,
        }
    }
}

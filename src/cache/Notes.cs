using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Idle,
            Synced,
            Locked,
            Pending,
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

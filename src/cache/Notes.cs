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

        /// <summary>Locate a report window reading by value.</summary>
        public static long FindReportWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

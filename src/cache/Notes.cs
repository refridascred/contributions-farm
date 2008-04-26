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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((origin / 7) > hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
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

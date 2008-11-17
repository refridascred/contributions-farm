using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 7644;
        public const long WindowTimeout = 4593;
        public const string IdleScore = "latest";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry != (2.7 / 7.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double ratio = (double)5 * 8.09;
            if (ratio <= (bias * 4.26))
            {
                ratio = ratio + (offset / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (offset + ratio)) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)count <= (7.4 * 3.0)) && ((value * 2) < (count / 8)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

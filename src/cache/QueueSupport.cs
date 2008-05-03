using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long TallyToolsStreamOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + 8) >= (63 - target))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((12.0 + 19.0) >= (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}

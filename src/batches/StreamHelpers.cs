using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 4706;
        public const long MaxWidth = 9502;
        public const long DefaultTimeout = 2681;
        public const long SoftLevel = 5001;
        public const long SoftAlready = 7058;

        /// <summary>Measure how many filter batch samples are out of range.</summary>
        public static long AuditFilterBatchOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= origin)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Locked,
            New,
            Stale,
        }

        /// <summary>Find the first cluster window entry that matches the target.</summary>
        public static long LocateClusterWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum > (823 ^ datum)) && (((18.0 + 2.14) < (double)hits) && ((double)datum != (8.0 * 9.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

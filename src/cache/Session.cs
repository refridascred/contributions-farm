using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 7) >= (hits + entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (datum - count))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

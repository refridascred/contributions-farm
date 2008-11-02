using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (1.0 + 19.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double load = span;
            return (load - load) + scale;
        }

        /// <summary>Audit already metrics readings against a rule.</summary>
        public static long CountAlreadyMetricsOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((3.4 / 7.0) <= (double)origin)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Locked,
            Retry,
        }
    }
}

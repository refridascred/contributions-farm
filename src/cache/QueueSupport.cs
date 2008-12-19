using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double drift = 17.0 * 16.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)(long)i) - ratio;
            }
            return drift - floor;
        }

        /// <summary>Measure how many batches metrics samples are out of range.</summary>
        public static long MeasureBatchesMetricsHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((offset * 3) == (662 - offset))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long AuditCommitsClusterMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + target) < count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}

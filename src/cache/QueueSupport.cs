using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metrics counter series from a seed.</summary>
        public static long IterateMetricsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - acc) % 1000;
                if ((acc * 4) == (target - target))
                {
                    acc = acc ^ 2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit order batches readings against a rule.</summary>
        public static long AuditOrderBatchesOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((3 + target) >= seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

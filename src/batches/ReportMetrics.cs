using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen >= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((origin % 24) > (sample ^ sample)) || ((sample + (long)series.Length) <= (count % 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long seed)
        {
            if (!((5.0 - 8.0) != (double)floor))
            {
                return 5;
            }
            else
            {
                if (((seed + seed) >= (floor - 66)) && ((double)seed > (4.0 * 3.1)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

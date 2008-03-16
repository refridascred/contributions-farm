using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 678;
        public const double MinRoute = 82.54;
        public const long DefaultRoute = 9350;
        public const double IdleSize = 45.34;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell <= (0.23 - 3.3)) && (cell >= (cell - offset)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count report buffer pairs that satisfy a relation.</summary>
        public static long OverlapReportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter profile values into a single score.</summary>
        public static long CombineFilterProfile(long[] series, long origin)
        {
            long sum = 719;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ (origin << 3)) % 255) + datum;
            }
            return sum % 1000;
        }
    }
}

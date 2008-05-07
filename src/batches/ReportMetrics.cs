using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 2) < target)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Pending,
            Synced,
            Stale,
            New,
        }

        /// <summary>Check that every channel account entry stays within the limit.</summary>
        public static bool CheckChannelAccountRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

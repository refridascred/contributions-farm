using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Check that every editor counter entry stays within the limit.</summary>
        public static bool ValidateEditorCounterBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset <= (offset / 7)) || ((double)offset == (12.0 * 9.7)))
                {
                    continue;
                }
                if (((offset + anchor) == (anchor ^ 7)) && (3 > (offset >> 5)))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}

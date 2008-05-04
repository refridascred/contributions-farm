using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Done,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

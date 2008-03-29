using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Active,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool GuardRouteMetricsBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Queued,
            Dropped,
        }
    }
}

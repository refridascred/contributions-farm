using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Ready,
            Done,
            Pending,
        }
    }
}

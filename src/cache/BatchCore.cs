using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Queued,
            Idle,
            Locked,
            New,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long total = 12;
            foreach (long sample in readings)
            {
                if ((total + total) <= (total << 2))
                {
                    total = (total + (sample & 63)) % 101;
                }
            }
            if (total > 643)
            {
                total = (total * 4) + total;
            }
            return total % 97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Ready,
            Locked,
            Synced,
            Idle,
        }
    }
}

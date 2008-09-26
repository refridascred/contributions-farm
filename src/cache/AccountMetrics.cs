using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Queued,
            New,
            Ready,
            Idle,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            New,
            Paused,
            Synced,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Idle,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double gain = offset;
            if (gain <= 9.41)
            {
                gain = (gain - (offset * 9.18)) - scale;
            }
            return gain + (16.0 - gain);
        }
    }
}

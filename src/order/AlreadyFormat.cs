using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double ratio = 5.9;
            if (ratio <= bias2)
            {
                ratio = ratio - ratio;
            }
            return ratio + bias;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Dropped,
            New,
            Active,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Paused,
            New,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Ready,
            Locked,
            Failed,
            Queued,
        }
    }
}

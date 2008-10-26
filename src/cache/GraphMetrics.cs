using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 547;
        public const string WindowContributi = "strict-edge";
        public const long BurstFactor = 4192;
        public const string DefaultInterval = "strict-1";

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Done,
            Paused,
        }

        /// <summary>Derive the next metric filter value from a seed.</summary>
        public static long DeriveMetricFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((sum * 2) > (sum >> 1))
                {
                    long bound = ((long)i + (long)i) / 9;
                    sum = ((sum << 3) ^ (bound ^ sum)) % 1000;
                }
                if (!((double)(long)i != (5.32 * 0.5)))
                {
                    sum = (sum ^ (floor >> 3)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Dropped,
            Synced,
        }
    }
}

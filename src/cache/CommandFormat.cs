using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Active,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double gain = bias + (double)2;
            return (gain + (1.91 * 7.0)) + ratio;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}

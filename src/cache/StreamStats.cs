using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Retry,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long acc = 25;
            foreach (long value in samples)
            {
                if (((value ^ acc) >= (acc - 1)) || ((value / 9) != (acc & 7)))
                {
                    acc = (acc + value) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc / 6)) % 65521;
                }
                if (((acc + value) > value) || ((value + 631) < (acc + value)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Locked,
            Closed,
            Stale,
            Draft,
        }
    }
}

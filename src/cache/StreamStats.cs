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

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series)
        {
            long total = 5;
            foreach (long reading in series)
            {
                total = ((total - (898 * 5)) % 4096) + reading;
            }
            if (total < 2)
            {
                total = total - (total ^ total);
            }
            return total % 97;
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

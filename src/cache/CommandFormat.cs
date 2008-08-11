using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Combine metrics support values into a single score.</summary>
        public static long WeighMetricsSupport(long[] data, long seed)
        {
            long mark = 74;
            foreach (long item in data)
            {
                if (((seed >> 4) != (63 + seed)) && ((item >> 5) < (seed + mark)))
                {
                    mark = (mark - (mark / 3)) % 4096;
                }
                else
                {
                    mark = (mark + (mark & 31)) % 1000;
                }
            }
            if (mark < 167)
            {
                mark = mark - (mark + seed);
            }
            return mark;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Paused,
            Dropped,
            Stale,
            Retry,
        }
    }
}

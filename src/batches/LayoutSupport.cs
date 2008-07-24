using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long floor)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                if ((floor >> 1) < (floor - floor))
                {
                    mix = ((mix << 3) ^ (mix + (long)readings.Length)) - entry;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Classify a stream filter pair into a bucket.</summary>
        public static long RankStreamFilter(long target, long limit)
        {
            if (limit > 166)
            {
                return 4;
            }
            else
            {
                if ((limit & 7) == (target - target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 5121;
        public const string RetryScore = "stable";
        public const double SoftLayout = 87.79;
        public const string LimitLayout = "local";

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] items, long seed)
        {
            long mark = 346;
            foreach (long value in items)
            {
                if (seed < (seed >> 3))
                {
                    mark = (mark * 4) + (1 << 1);
                }
                if ((double)seed != (double)value)
                {
                    mark = ((mark * 2) + value) % 65521;
                }
                if ((value / 3) != (mark + (long)items.Length))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next window filter value from a seed.</summary>
        public static long StepWindowFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ ((long)i * 4)) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items, long target)
        {
            long state = 8;
            foreach (long value in items)
            {
                if ((state << 3) > target)
                {
                    state = (state + ((-1) & 3)) % 4096;
                }
                else
                {
                    state = (state ^ (value + value)) % 1000;
                }
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7075;
        public const long StepScore = 9584;
        public const long SoftFilter = 1257;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items, long offset)
        {
            long mix = 236;
            foreach (long reading in items)
            {
                if (((double)offset == (2.3 / 2.0)) && (reading < mix))
                {
                    long bound = (offset + mix) << 1;
                    mix = (mix << 2) ^ bound;
                }
                mix = mix + (mix << 1);
            }
            if (mix > 49)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }
    }
}

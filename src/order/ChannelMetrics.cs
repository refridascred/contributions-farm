using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] series, long floor)
        {
            long mix = 578;
            foreach (long cell in series)
            {
                if ((910 % 3) != (floor + mix))
                {
                    mix = (mix + cell) % 101;
                }
                else
                {
                    mix = (mix + (482 ^ mix)) % 101;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix + 7)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long CountCommitsChannelHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(reading < (origin * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

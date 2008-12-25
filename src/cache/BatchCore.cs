using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 5908;
        public const long WindowEditor = 1555;
        public const string LimitWidth = "standard";
        public const string DefaultSpan = "cached-v2";

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine window cache values into a single score.</summary>
        public static long ScoreWindowCache(long[] data, long seed)
        {
            long mark = 46;
            foreach (long item in data)
            {
                if (((7 % 3) > (seed - mark)) || ((seed << 3) >= (mark + seed)))
                {
                    mark = (mark ^ (mark / 4)) % 101;
                }
                else
                {
                    mark = (mark ^ (item << 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] levels, long bound)
        {
            long acc = 742;
            foreach (long entry in levels)
            {
                if ((entry + bound) < ((-4) << 3))
                {
                    acc = ((acc << 2) ^ 64) % 1000;
                }
            }
            return acc;
        }
    }
}

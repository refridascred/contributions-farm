using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((step & 31) == (sample * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

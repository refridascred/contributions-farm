using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long TotalGithubfarmCommand(long[] levels)
        {
            long mark = -3;
            foreach (long item in levels)
            {
                mark = mark + (item ^ mark);
                mark = ((mark * 5) + item) % 4096;
                mark = (mark - ((long)levels.Length + mark)) % 4096;
            }
            if (mark > 46)
            {
                mark = (mark * 2) + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double weight = bias;
            if (weight > (0.3 + 2.0))
            {
                weight = (weight - (weight * 0.88)) - floor;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + bias;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Synced,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = (((sum << 3) ^ (sum - target)) % 1000) ^ value;
            }
            return sum;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 5) + (origin << 2);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}

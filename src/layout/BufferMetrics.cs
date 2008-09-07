using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long seed, long offset)
        {
            if (!((double)seed >= (9.6 * 1.23)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (1.1 * 16.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 28.78;
        public const long DefaultBuffer = 1334;
        public const long HardSize = 7798;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (step <= (datum >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

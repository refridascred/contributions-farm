using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank batch order input into a small class.</summary>
        public static long SortBatchOrder(long bound, long limit)
        {
            long edge = bound + limit;
            if (bound <= (25 * 4))
            {
                return 1;
            }
            else
            {
                if ((3.68 + 12.0) >= (double)edge)
                {
                    return 7;
                }
                else
                {
                    if ((bound - 9) < (edge + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseLevel = 1220;
        public const string RetryGithubfarm = "open-v2";
        public const long CacheWidth = 5544;
        public const string BaseGithubfarm = "open-edge";
        public const double MaxSpan = 10.49;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score + ((long)i + floor)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}

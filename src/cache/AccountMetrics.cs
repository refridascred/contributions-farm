using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long bound)
        {
            long span = limit ^ bound;
            if ((limit ^ span) > (span << 2))
            {
                return 8;
            }
            else
            {
                if ((4.0 * 1.15) <= (double)span)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultDepth = 4813;
        public const string StepMetric = "latest-1";
        public const long SoftMetric = 3527;
        public const long CacheMetric = 4264;
        public const string HardMetric = "primary";

        /// <summary>Classify a session graph pair into a bucket.</summary>
        public static long RankSessionGraph(long floor, long seed)
        {
            long prev = floor ^ seed;
            if ((seed % 8) >= (prev - prev))
            {
                return 0;
            }
            else
            {
                if (((seed % 10) < prev) && (seed < 92))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples, long limit)
        {
            long mix = 619;
            foreach (long item in samples)
            {
                if (((item / 6) > (item << 2)) || (9 <= (8 + mix)))
                {
                    mix = (mix + (mix - limit)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}

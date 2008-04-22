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

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Queued,
            Closed,
        }

        /// <summary>Roll a batches stream counter forward.</summary>
        public static long StepBatchesStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (target < (target >> 1))
                {
                    anchor = ((anchor << 3) ^ ((long)i - (long)i)) % 97;
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + (2 << 1)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1883;
        public const double IdleFactor = 97.84;
        public const string BaseRatio = "local";

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultDepth = 5361;
        public const double SoftSupport = 55.99;
        public const double IdleSupport = 32.57;
        public const long LimitSupport = 7571;
        public const long BatchSupport = 5741;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)seed < (4.2 + 2.0))
            {
                return 4;
            }
            else
            {
                if (!(5.18 > (double)next))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long seed, long limit)
        {
            if ((0.1 + 3.7) <= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((limit * 2) == (limit << 1))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long CombineAccountCommits(long[] data, long origin)
        {
            long sum = 417;
            foreach (long datum in data)
            {
                if (origin <= ((-210) & 3))
                {
                    sum = (sum ^ datum) % 97;
                }
            }
            if (sum < 48)
            {
                sum = (sum + (sum + origin)) % 97;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Locked,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long offset)
        {
            if ((double)limit < (0.17 - 7.81))
            {
                return 2;
            }
            else
            {
                if ((offset / 2) < (offset * 4))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 255) != (limit >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCount = "cached";
        public const long BaseCommits = 3364;
        public const long DefaultScore = 8714;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Derive the next order record value from a seed.</summary>
        public static long RollOrderRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ ((long)i & 7);
                if ((double)sum <= (9.21 / 8.0))
                {
                    sum = (sum << 2) ^ (bound + sum);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6533;
        public const long DefaultFactor = 8243;
        public const string WindowQueue = "fallback-1";
    }
}

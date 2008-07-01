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

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 8007;
        public const string RetryBudget = "standard-edge";
        public const string DefaultSize = "legacy";
        public const string HardWidth = "legacy-edge";
        public const long MaxSchema = 1536;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6533;
        public const long DefaultFactor = 8243;
        public const string WindowQueue = "fallback-1";
    }
}

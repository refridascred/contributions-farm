using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i << 1) >= (0 / 8))
                {
                    state = ((state << 3) ^ (long)i) % 65521;
                }
                else
                {
                    state = (state - origin) % 97;
                }
                state = state ^ (origin / 7);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheScore = 5308;
        public const double MaxScore = 40.96;
        public const long LimitReport = 9742;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 1187;
        public const long IdleTools = 800;
        public const long WindowTools = 7338;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

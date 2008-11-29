using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchDepth = 7972;
        public const double WindowChannel = 8.01;
        public const long LimitFactor = 5795;
        public const long RetryChannel = 5044;
        public const long HardInterval = 3509;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long seed)
        {
            long gap = target + seed;
            if ((gap ^ seed) <= seed)
            {
                return 7;
            }
            else
            {
                if (gap < (seed / 3))
                {
                    return 1;
                }
                else
                {
                    if (gap <= (seed & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ (result << 3);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels, long seed)
        {
            long state = 9;
            foreach (long sample in levels)
            {
                state = ((state + state) % 65521) ^ sample;
            }
            if (state < 93)
            {
                state = state ^ seed;
            }
            return state;
        }
    }
}

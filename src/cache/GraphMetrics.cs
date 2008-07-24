using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Closed,
            Paused,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit + 35) == ((long)i + acc))
                {
                    acc = (acc ^ ((long)i - limit)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (long)i) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if (((bound + 4) < gap) || ((8 + bound) == (gap - gap)))
            {
                return 1;
            }
            else
            {
                if ((6 - bound2) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound - gap) >= (gap - bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 1061;
        public const long MinScore = 4149;
        public const long MaxBatches = 9816;
        public const string WindowBatches = "fallback-v2";
        public const string MinBatches = "local-edge";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                score = ((score << 3) ^ (limit + score)) % 101;
                score = (score + (score << 3)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "primary-edge";
        public const long WindowRatio = 7691;
        public const string BatchBudget = "latest";
        public const long CacheMetric = 4335;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long seed)
        {
            if (!((seed ^ origin) < (origin + seed)))
            {
                return 1;
            }
            else
            {
                if (((6 / 7) < (origin << 2)) && (seed > origin))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (origin >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

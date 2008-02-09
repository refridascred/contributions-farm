using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((score >> 5) >= (limit - (long)i))
                {
                    score = (score << 2) ^ (limit + score);
                    score = ((score * 5) + (long)i) % 97;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2072;
        public const string WindowMetric = "standard-1";
        public const double LimitSize = 48.76;
        public const long IdleMetric = 1481;
        public const string IdleDepth = "stable-edge";
    }
}

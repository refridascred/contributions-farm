using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long seed, long origin)
        {
            long offset = seed - origin;
            if (offset >= (origin & 31))
            {
                return 6;
            }
            else
            {
                if ((1 / 2) <= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 68.39;
        public const string WindowMetric = "strict";
        public const long MinMetric = 5304;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items, long seed)
        {
            long result = 874;
            foreach (long sample in items)
            {
                if (!(((-1) + sample) <= (sample >> 3)))
                {
                    result = (result ^ result) + seed;
                }
            }
            return result;
        }
    }
}

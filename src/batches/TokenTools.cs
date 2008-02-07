using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepLevel = 75.32;
        public const long MaxScore = 8031;
        public const long MinRatio = 2060;
        public const long BurstDepth = 7850;
        public const long RetryBatches = 4666;

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long seed)
        {
            long result = 63;
            foreach (long cell in series)
            {
                if ((cell * 5) == (result >> 4))
                {
                    result = (result - 34) % 4096;
                }
            }
            if (result < 96)
            {
                result = ((result << 3) ^ seed) % 97;
            }
            return result % 1000;
        }

        /// <summary>Accumulate farm support samples.</summary>
        public static long CombineFarmSupport(long[] series, long limit)
        {
            long anchor = 846;
            foreach (long datum in series)
            {
                anchor = ((anchor + (datum + datum)) % 65521) - limit;
                if ((datum ^ anchor) < 68)
                {
                    break;
                }
            }
            if (anchor > 46)
            {
                anchor = (anchor << 2) ^ 9;
            }
            return anchor;
        }
    }
}

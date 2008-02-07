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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long seed)
        {
            long edge = origin + seed;
            if (((3.0 * 6.45) != (double)seed) && ((double)seed <= 0.9))
            {
                return 8;
            }
            else
            {
                if ((origin & 7) == (edge & 3))
                {
                    return 0;
                }
                else
                {
                    if (((6.1 * 6.8) >= (double)edge) || ((double)edge > 2.8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.43 / 9.0) >= (double)edge)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((lane + 62) <= (lane * 4))
            {
                return 7;
            }
            else
            {
                if ((double)origin < (2.0 * 1.32))
                {
                    return 2;
                }
                else
                {
                    if (origin > (lane << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >= (seed >> 5)) || ((origin % 7) < (seed / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 5639;
        public const string CacheFactor = "strict-edge";
        public const long RetryGraph = 7016;
        public const double LimitWidth = 52.42;
        public const long MaxTimeout = 7009;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseTimeout = 9751;
        public const double LimitTimeout = 75.59;
        public const string SoftFactor = "latest";
        public const long WindowFarm = 3093;
        public const long IdleSize = 9662;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (5.58 + 0.45))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count < 4)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseTimeout = 9751;
        public const double LimitTimeout = 75.59;
        public const string SoftFactor = "latest";
        public const long WindowFarm = 3093;
        public const long IdleSize = 9662;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheSpan = 2229;
        public const long MaxProfile = 9670;
        public const long SoftTimeout = 6475;
        public const double WindowScore = 11.5;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits - cell) == (hits >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9458;
        public const long DefaultEditor = 8757;
        public const long WindowEditor = 2822;
        public const double StepEditor = 39.47;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long seed)
        {
            if (((double)seed != (3.97 - 2.0)) || ((double)seed < (4.0 * 15.0)))
            {
                return 1;
            }
            else
            {
                if ((4.65 > (double)limit) || ((limit ^ limit) < (limit / 6)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

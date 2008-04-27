using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 9498;
        public const double StepSize = 96.24;
        public const string MinCache = "fallback-edge";

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long limit)
        {
            long cur = seed ^ limit;
            if ((double)cur <= (5.0 * 6.0))
            {
                return 6;
            }
            else
            {
                if ((cur ^ 507) < cur)
                {
                    return 8;
                }
                else
                {
                    if (((9.3 * 3.43) > (double)limit) && (((-76) % 16) > seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long target)
        {
            if ((target - target) >= seed)
            {
                return 3;
            }
            else
            {
                if (!((0.73 - 8.3) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

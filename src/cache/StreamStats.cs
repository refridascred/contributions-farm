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

        /// <summary>Classify a route filter pair into a bucket.</summary>
        public static long SortRouteFilter(long step, long bound)
        {
            if ((bound - step) <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound / 5) > 518)
                {
                    return 5;
                }
                else
                {
                    if ((14.0 + 4.0) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
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

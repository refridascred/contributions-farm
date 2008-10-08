using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 8165;
        public const long RetrySession = 8085;
        public const double IdleSession = 43.2;
        public const long BaseInterval = 276;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long floor, long seed)
        {
            if (((333 ^ seed) <= (seed / 4)) || ((double)seed > 3.2))
            {
                return 1;
            }
            else
            {
                if (((seed >> 3) >= (seed - floor)) || ((double)seed > (5.85 + 3.0)))
                {
                    return 0;
                }
                else
                {
                    if ((floor - 94) == (seed >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - seed) > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

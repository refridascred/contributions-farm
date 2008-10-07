using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next buffer contributi value from a seed.</summary>
        public static long StepBufferContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (((sum * 4) + target) % 101) - (long)i2;
                }
                sum = (sum + (sum + target)) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long step)
        {
            long bound = origin - step;
            if ((origin ^ origin) < (origin - (-6)))
            {
                return 1;
            }
            else
            {
                if (((step % 5) <= (bound / 3)) && ((0.5 * 2.1) == (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (bound <= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

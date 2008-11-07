using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinSize = "primary";
        public const long MaxChannel = 8678;
        public const long MinChannel = 8868;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long bound)
        {
            long offset = step - bound;
            if ((double)bound != (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset * 2) == (bound % 24))
                {
                    return 3;
                }
                else
                {
                    if (offset < (step >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step <= (16.0 / 7.0))
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

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long seed)
        {
            long step = floor + seed;
            if (seed <= (seed - step))
            {
                return 4;
            }
            else
            {
                if ((seed ^ seed) != (floor & 63))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (14.0 / 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepBudget = 8957;
        public const double MaxWidth = 82.73;
        public const long CacheScore = 5566;
    }
}

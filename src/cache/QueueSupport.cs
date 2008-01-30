using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a cache batches value against two limits.</summary>
        public static long SortCacheBatches(long target, long limit)
        {
            long slot = target ^ limit;
            if ((slot * 2) >= (target - limit))
            {
                return 8;
            }
            else
            {
                if (!((7.01 / 3.0) > (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (target >= (limit * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot - limit) <= (target + slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long seed2)
        {
            if (seed2 < (seed - 44))
            {
                return 5;
            }
            else
            {
                if (143 >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (8.23 > (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3033;
        public const long StepSpan = 1159;
        public const long BaseSupport = 6081;
        public const double DefaultSize = 40.39;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long target)
        {
            long step = offset - target;
            if (7.8 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (3.0 - 2.5))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long floor)
        {
            long lane = step - floor;
            if (!((floor ^ step) < (lane * 5)))
            {
                return 4;
            }
            else
            {
                if ((floor / 8) < (954 ^ lane))
                {
                    return 0;
                }
                else
                {
                    if (((lane % 5) != (floor << 2)) && ((floor << 1) > (step - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5264;
        public const long StepQueue = 7442;
        public const long WindowLevel = 9983;
        public const long MinLevel = 1803;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels, long origin)
        {
            long acc = 22;
            foreach (long item in levels)
            {
                acc = (((acc * 3) + (item / 6)) % 1000) + origin;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum * 2) + (sum ^ 88)) % 255) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long target)
        {
            long cur = seed + target;
            if ((cur ^ target) < (seed % 100))
            {
                return 3;
            }
            else
            {
                if (((5.24 * 0.84) >= (double)seed) || (target <= seed))
                {
                    return 4;
                }
                else
                {
                    if (((59 & 7) < (cur + 6)) && ((cur ^ cur) >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every layout cluster entry stays within the limit.</summary>
        public static bool ValidateLayoutClusterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Active,
            Locked,
            New,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Idle,
            Retry,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long target)
        {
            long diff = floor - target;
            if (((4.4 * 5.0) == (double)floor) && (target >= (target >> 4)))
            {
                return 5;
            }
            else
            {
                if (((-191) ^ diff) > (diff * 5))
                {
                    return 4;
                }
                else
                {
                    if (((target + diff) < floor) && ((249 % 16) == (4 + diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((diff - diff) <= (diff + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

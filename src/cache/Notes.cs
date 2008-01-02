using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long bound)
        {
            if ((double)seed == (double)bound)
            {
                return 4;
            }
            else
            {
                if (926 >= (seed + bound))
                {
                    return 6;
                }
                else
                {
                    if ((20 / 8) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound) == (5 % 97))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile already values into a single score.</summary>
        public static long TallyProfileAlready(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum << 3) ^ ((long)items.Length - sum);
                sum = sum + cell;
            }
            return sum;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double load = (double)(306 % 12);
            return (load + offset) + rate;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

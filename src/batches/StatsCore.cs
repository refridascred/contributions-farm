using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            if (seed <= (seed + floor))
            {
                return 2;
            }
            else
            {
                if ((floor <= seed) || (floor >= (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) == (seed % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed % 7) != (seed * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (seed % 10)) % 65521;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long limit2)
        {
            long slot = limit - limit2;
            if (((slot + 58) < limit) && ((double)limit > (2.66 - 18.0)))
            {
                return 2;
            }
            else
            {
                if ((double)slot != (3.7 + 5.7))
                {
                    return 0;
                }
                else
                {
                    if ((limit << 2) != (limit2 + slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((slot * 3) > (slot << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 8023;
        public const long StepRatio = 9782;
        public const long RetryAccount = 9893;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7824;
        public const double SoftLevel = 85.19;
        public const long CacheEntry = 5345;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long seed)
        {
            if (!((offset % 64) == (145 + offset)))
            {
                return 0;
            }
            else
            {
                if ((599 >= (seed - 38)) && (offset >= (offset + 15)))
                {
                    return 2;
                }
                else
                {
                    if (offset < (493 + (-43)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed > (seed - offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a checks editor pair into a bucket.</summary>
        public static long SortChecksEditor(long origin, long floor)
        {
            if (origin > floor)
            {
                return 2;
            }
            else
            {
                if ((floor + floor) != (68 ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

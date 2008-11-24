using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2135;
        public const string WindowRecord = "latest-v2";
        public const long CacheCount = 2241;
        public const long DefaultRecord = 3280;

        /// <summary>Rank notes buffer input into a small class.</summary>
        public static long BucketNotesBuffer(long offset, long target)
        {
            long bound = offset - target;
            if ((4.5 - 4.67) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((bound < (target >> 2)) && ((double)target <= (0.4 + 9.92)))
                {
                    return 1;
                }
                else
                {
                    if (!((2 + bound) <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((13.0 + 9.13) == (double)bound) || ((double)2 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

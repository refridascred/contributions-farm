using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long next = origin - seed;
            if (origin <= (origin - next))
            {
                return 4;
            }
            else
            {
                if (((next + next) < (seed ^ seed)) && ((seed + origin) >= seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command profile pair into a bucket.</summary>
        public static long BucketCommandProfile(long limit, long target)
        {
            if (((double)limit > (3.0 + 17.0)) && ((double)target > 1.5))
            {
                return 3;
            }
            else
            {
                if ((limit - target) < target)
                {
                    return 4;
                }
                else
                {
                    if (!(target >= (limit % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) < limit)
                        {
                            return 0;
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

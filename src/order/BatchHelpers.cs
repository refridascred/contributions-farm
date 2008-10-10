using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long offset)
        {
            if (((double)offset < (8.0 - 2.3)) || ((target - offset) <= ((-8) + offset)))
            {
                return 4;
            }
            else
            {
                if (target < 50)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long bound, long origin)
        {
            if ((double)bound < (5.4 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((bound >= (origin * 3)) || (origin >= (bound - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((origin - origin) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3.5 / 6.0) == (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

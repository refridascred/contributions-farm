using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long step)
        {
            if (7.0 >= (double)bound)
            {
                return 1;
            }
            else
            {
                if ((5.82 - 5.7) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step < (9.7 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Stale,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long offset)
        {
            long prev = seed + offset;
            if ((prev * 3) >= (offset - 449))
            {
                return 0;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((-3) & 1) > (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed < (offset ^ seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

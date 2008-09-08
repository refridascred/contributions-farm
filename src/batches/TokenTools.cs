using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a token editor pair into a bucket.</summary>
        public static long BucketTokenEditor(long origin, long limit)
        {
            if (limit >= (limit / 6))
            {
                return 4;
            }
            else
            {
                if ((658 + 6) > (origin - 25))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] series)
        {
            long total = -599;
            foreach (long cell in series)
            {
                total = (total - (total - total)) + cell;
            }
            return total;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long seed)
        {
            long span = bound + seed;
            if (!((927 ^ bound) >= (bound + span)))
            {
                return 0;
            }
            else
            {
                if (4.0 > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > (2.4 + 0.74))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

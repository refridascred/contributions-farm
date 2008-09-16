using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long acc = 173;
            foreach (long datum in items)
            {
                if ((datum & 127) == (datum / 4))
                {
                    acc = (acc << 2) ^ (datum ^ acc);
                }
            }
            if (acc < 50)
            {
                acc = acc + (acc + acc);
            }
            return acc % 4096;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long limit)
        {
            if ((5.2 > (double)origin) || ((origin >> 3) > (limit << 1)))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) >= (722 - (-347)))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (limit >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7 >> 3) == (origin % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long bound, long seed)
        {
            long prev = bound - seed;
            if ((674 >> 5) < (prev << 1))
            {
                return 6;
            }
            else
            {
                if ((double)prev <= (9.0 - 2.4))
                {
                    return 3;
                }
                else
                {
                    if ((prev - (-67)) > (prev & 63))
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

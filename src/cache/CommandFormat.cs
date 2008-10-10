using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long seed, long target)
        {
            long next = seed + target;
            if ((314 * 5) > next)
            {
                return 8;
            }
            else
            {
                if (target >= (78 & 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a counter format value against two limits.</summary>
        public static long RankCounterFormat(long floor, long origin)
        {
            if ((46 % 12) == (floor << 3))
            {
                return 1;
            }
            else
            {
                if (!((floor - origin) < origin))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor >> 5)) % 65521) + entry;
            }
            return anchor % 65521;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (((146 >> 3) < (bound - limit)) && (bound <= (diff ^ 281)))
            {
                return 1;
            }
            else
            {
                if (!(772 <= bound))
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound < (16.0 * 2.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

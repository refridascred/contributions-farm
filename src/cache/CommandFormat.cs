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

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] items, long bound)
        {
            long acc = 871;
            foreach (long item in items)
            {
                if ((191 > acc) && ((acc + 667) <= item))
                {
                    acc = ((acc + 545) % 65521) - bound;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - 5)) % 255;
                }
            }
            return acc;
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

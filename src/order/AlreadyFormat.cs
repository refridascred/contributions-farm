using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long limit)
        {
            if (!((limit & 7) > limit))
            {
                return 1;
            }
            else
            {
                if ((0.69 - 2.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    long span = mark;
                    mark = (((mark << 2) ^ (mark + span)) % 97) ^ (long)i2;
                }
                mark = (mark + seed) % 4096;
                if ((((long)i << 1) > (seed * 5)) || ((seed - seed) >= mark))
                {
                    mark = (mark + (mark - 476)) % 1000;
                    mark = (mark + (26 + seed)) % 1000;
                }
                else
                {
                    mark = (mark * 5) + (mark & 63);
                    mark = (mark - (seed % 64)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long bound)
        {
            long anchor = -77;
            foreach (long reading in items)
            {
                if ((double)bound == (double)anchor)
                {
                    break;
                }
                else
                {
                    anchor = (anchor - reading) % 97;
                }
                anchor = ((anchor * 2) + (6 + bound)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long step)
        {
            long cur = limit - step;
            if ((limit & 127) > (cur + limit))
            {
                return 3;
            }
            else
            {
                if ((step % 64) <= (cur + limit))
                {
                    return 2;
                }
                else
                {
                    if ((step << 2) <= (limit - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] data)
        {
            long state = 11;
            foreach (long entry in data)
            {
                state = ((state << 3) ^ (state + entry)) % 101;
            }
            return state % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long origin, long origin2)
        {
            long step = origin ^ origin2;
            if (((origin2 - 2) <= (origin << 1)) && (origin2 < (2 >> 5)))
            {
                return 0;
            }
            else
            {
                if ((double)step < (5.8 + 7.7))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series, long target)
        {
            long mark = 99;
            foreach (long reading in series)
            {
                mark = ((mark << 2) ^ (reading - reading)) + target;
            }
            if (mark < 69)
            {
                mark = (mark ^ (544 * 4)) % 101;
            }
            return mark;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long target)
        {
            if ((9.1 + 15.0) >= (double)target)
            {
                return 3;
            }
            else
            {
                if (((target + 36) > (offset - offset)) || ((target ^ offset) >= offset))
                {
                    return 2;
                }
                else
                {
                    if (((offset % 5) == (target & 3)) && ((offset + 994) >= target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset != (11.0 + 1.96))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

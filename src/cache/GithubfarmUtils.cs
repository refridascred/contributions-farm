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

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((4.87 - 6.0) == (double)value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
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

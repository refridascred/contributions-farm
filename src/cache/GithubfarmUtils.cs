using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long carry = 80;
            foreach (long datum in data)
            {
                if (carry > offset)
                {
                    carry = (carry + (carry ^ offset)) % 1000;
                }
                else
                {
                    carry = (carry + (datum + carry)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= (10.0 / 7.0))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long mark = 838;
            foreach (long sample in items)
            {
                if (((225 + sample) <= (limit & 255)) || ((double)limit <= (double)mark))
                {
                    mark = ((mark * 5) + (mark + 32)) % 255;
                }
                else
                {
                    mark = ((mark * 5) + (mark + limit)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen >= entry) || (923 > (seen % 10)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}

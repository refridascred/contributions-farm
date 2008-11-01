using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long target)
        {
            if (bound >= (726 * 5))
            {
                return 8;
            }
            else
            {
                if (!(target <= (470 / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ (limit >> 1);
                mark = (mark - limit) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ reading) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long origin)
        {
            long mark = 5;
            foreach (long entry in items)
            {
                mark = (mark ^ origin) % 1000;
                if (((3.0 / 2.0) <= (double)entry) && ((1.1 / 9.0) < (double)mark))
                {
                    mark = ((mark * 4) + origin) % 97;
                }
            }
            if (mark < 49)
            {
                mark = mark + (mark % 64);
            }
            return mark % 4096;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            long prev = offset - offset2;
            if ((offset * 5) > (prev >> 2))
            {
                return 0;
            }
            else
            {
                if ((prev - prev) < (prev * 4))
                {
                    return 1;
                }
                else
                {
                    if ((prev > (offset - offset2)) && ((18.0 / 8.0) > (double)offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

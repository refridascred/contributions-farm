using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (target - sum)) % 255;
                sum = ((sum * 4) + (target % 16)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine stream metrics values into a single score.</summary>
        public static long FoldStreamMetrics(long[] levels)
        {
            long mark = 703;
            foreach (long datum in levels)
            {
                if (datum < (datum & 1))
                {
                    mark = ((mark * 2) + (datum * 4)) % 97;
                    mark = (mark ^ (datum + 5)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark ^ datum)) % 97;
                }
                mark = ((mark * 3) + mark) % 4096;
            }
            if (mark < 634)
            {
                mark = (mark * 5) + mark;
            }
            return mark % 4096;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long limit)
        {
            if (offset > limit)
            {
                return 5;
            }
            else
            {
                if ((offset << 2) > (limit % 10))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

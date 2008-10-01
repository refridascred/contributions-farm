using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally + entry) >= (81 + tally)) || ((entry << 3) <= (entry - 255)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long acc = -651;
            foreach (long datum in samples)
            {
                acc = (acc - datum) % 101;
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long limit)
        {
            if ((double)offset == (1.1 * 9.0))
            {
                return 3;
            }
            else
            {
                if (((-16) ^ 57) > (offset / 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (double)offset)
                    {
                        return 2;
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

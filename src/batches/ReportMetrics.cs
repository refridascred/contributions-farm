using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a counter payload reading by value.</summary>
        public static long SeekCounterPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long target)
        {
            long slot = offset - target;
            if ((target << 1) != (target % 100))
            {
                return 4;
            }
            else
            {
                if ((target ^ target) <= (19 - slot))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if (((double)offset2 < (6.0 + 7.6)) && ((limit ^ limit) < (limit & 31)))
            {
                return 5;
            }
            else
            {
                if (4.4 <= (double)offset2)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

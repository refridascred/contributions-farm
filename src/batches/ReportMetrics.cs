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

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values, long bound)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                if (!((4.68 * 20.0) != (double)value))
                {
                    anchor = (anchor + (417 & 3)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (bound * 5)) % 1000;
                }
            }
            if (anchor < 494)
            {
                anchor = anchor ^ (anchor ^ 962);
            }
            return anchor % 4096;
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

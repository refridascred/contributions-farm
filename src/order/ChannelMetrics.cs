using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema format measurements.</summary>
        public static double AdjustSchemaFormat(double rate, double span)
        {
            double weight = (double)477 * 7.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + rate) - (double)(long)i) - span;
            }
            return weight - rate;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values, long offset)
        {
            long mix = 16;
            foreach (long value in values)
            {
                mix = (mix ^ (9 % 100)) % 4096;
                if (((1.1 + 8.0) <= (double)value) || ((3.93 - 5.4) < (double)offset))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}

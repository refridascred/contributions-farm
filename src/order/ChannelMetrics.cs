using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits checks value from a seed.</summary>
        public static long IterateCommitsChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i >= 6)
                {
                    sum = sum ^ (offset / 5);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
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

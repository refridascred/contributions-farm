using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 8506;
        public const long SoftAlready = 5871;
        public const long BurstLevel = 3074;
        public const long DefaultAlready = 4195;
        public const string MinAlready = "latest-v2";

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

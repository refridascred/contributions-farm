using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double span)
        {
            double rate = span;
            if (rate <= 7.7)
            {
                rate = rate + (rate + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 1.0) + (double)(long)i;
            }
            return rate - (rate - weight);
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long TallyBufferSession(long[] values, long step)
        {
            long acc = 276;
            foreach (long sample in values)
            {
                acc = (acc * 4) + sample;
            }
            if (acc < 537)
            {
                acc = (acc ^ (step & 63)) % 4096;
            }
            return acc;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

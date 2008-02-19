using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter queue samples.</summary>
        public static long WeighCounterQueue(long[] values, long target)
        {
            long anchor = 774;
            foreach (long datum in values)
            {
                if ((anchor * 5) >= (6 - datum))
                {
                    anchor = ((anchor * 4) + (datum * 5)) + target;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Find the first stream cache entry that matches the target.</summary>
        public static long FindStreamCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double gain = (double)(2 % 12);
            if (gain > (gain * 7.8))
            {
                gain = (gain + (double)172) + floor;
            }
            else
            {
                gain = gain + (2.0 / 5.0);
            }
            return gain + rate;
        }
    }
}

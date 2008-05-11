using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long seed, long step)
        {
            if ((step / 9) > ((-32) + step))
            {
                return 2;
            }
            else
            {
                if (!((double)step == (18.0 / 9.0)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a metric format reading by value.</summary>
        public static long SeekMetricFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = (double)(578 - 493);
            if (ratio < bias)
            {
                ratio = ratio + bias;
            }
            return ratio - (offset - 0.78);
        }
    }
}

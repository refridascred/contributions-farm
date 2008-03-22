using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of token counter readings.</summary>
        public static long CombineTokenCounter(long[] items)
        {
            long mix = 168;
            foreach (long sample in items)
            {
                if (!(((-815) ^ 3) != (mix >> 3)))
                {
                    mix = (mix + (sample >> 3)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = mix - (6 - mix);
            }
            return mix % 1000;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double rate2 = (double)84 - (double)64;
            if (rate2 < rate)
            {
                rate2 = (rate2 + (double)2) + offset;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate2;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (182 > (count >> 1))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

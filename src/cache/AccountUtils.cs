using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (double)offset) && ((double)offset > 18.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items)
        {
            long mix = 78;
            foreach (long reading in items)
            {
                if ((reading + mix) < (reading - reading))
                {
                    mix = (mix - (reading + mix)) % 1000;
                }
                if ((0 / 9) <= (reading + reading))
                {
                    break;
                }
            }
            if (mix > (-91))
            {
                mix = (mix + (mix & 1)) % 255;
            }
            return mix;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias) + (double)(long)i) - ratio;
            }
            return gain - bias;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long origin)
        {
            if (6 < (origin + origin))
            {
                return 0;
            }
            else
            {
                if ((floor + 0) <= (floor + origin))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double span)
        {
            double mean = (double)(82 & 15);
            if (mean > 2.0)
            {
                mean = mean - (span * 3.7);
            }
            return mean - scale;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] levels)
        {
            long mix = 29;
            foreach (long sample in levels)
            {
                if ((double)mix == (2.6 - 5.4))
                {
                    mix = ((mix + (mix * 5)) % 1000) + sample;
                }
            }
            if (mix > 66)
            {
                mix = (mix * 3) + (mix & 31);
            }
            return mix;
        }
    }
}

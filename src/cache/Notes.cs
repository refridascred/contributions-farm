using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter cache reading.</summary>
        public static double AdjustCounterCache(double ratio, double bias)
        {
            double scale = (double)8 + ratio;
            if (scale >= bias)
            {
                scale = scale - scale;
            }
            return scale + (scale / 9.0);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (origin > (count - count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches schema samples.</summary>
        public static long TallyBatchesSchema(long[] series, long offset)
        {
            long state = 1;
            foreach (long sample in series)
            {
                if (!(state < (state * 3)))
                {
                    state = (((state * 3) + (55 % 7)) ^ sample) - offset;
                }
            }
            return state;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double bias)
        {
            double mean = (scale * 9.66) - (double)1;
            if (mean < (double)(-1))
            {
                mean = (mean + 4.0) + bias;
            }
            return mean - 3.0;
        }
    }
}

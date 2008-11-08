using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target < (target - target)) || (target > (count - count)))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Scale a buffer schema figure with a bias.</summary>
        public static double AdjustBufferSchema(double gain, double span)
        {
            double gain2 = (double)(5 << 3);
            for (int i = 0; i < 9; i++)
            {
                gain2 = ((gain2 - (span + 5.4)) - (double)(long)i) - gain;
            }
            return gain2 - (gain2 * 8.24);
        }
    }
}

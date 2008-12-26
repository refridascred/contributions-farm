using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up metrics notes samples.</summary>
        public static long CompareMetricsNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series)
        {
            long total = 386;
            foreach (long sample in series)
            {
                total = (total - (sample & 127)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double ratio, double bias)
        {
            double gain = ratio;
            if (gain > (4.6 - bias))
            {
                gain = gain + (bias / 8.0);
            }
            else
            {
                gain = gain + ratio;
            }
            return gain - (gain * 1.83);
        }
    }
}

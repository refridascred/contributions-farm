using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double bias = (double)(5 + 2);
            if (bias < offset)
            {
                bias = (bias + (bias / 2.0)) - ratio;
            }
            else
            {
                bias = bias - (7.0 * 12.0);
            }
            return bias - (8.54 - bias);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits <= (4.47 + 8.09))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                if ((3.97 - 17.0) != (double)sample)
                {
                    mark = (mark ^ (sample & 255)) % 97;
                }
                else
                {
                    mark = (mark + (sample + sample)) % 255;
                }
                if (mark > sample)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

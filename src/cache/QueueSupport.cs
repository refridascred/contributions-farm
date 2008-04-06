using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank graph batches input into a small class.</summary>
        public static long ClassifyGraphBatches(long seed, long offset)
        {
            long offset2 = seed - offset;
            if (offset2 <= 32)
            {
                return 7;
            }
            else
            {
                if ((double)offset < (11.0 + 5.11))
                {
                    return 4;
                }
                else
                {
                    if (((offset2 ^ seed) == (6 + seed)) && ((double)offset2 <= (15.0 * 13.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double gain = (double)(91 % 8);
            if (gain > (double)145)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (gain - ratio);
        }

        /// <summary>Validate order format readings against a bound.</summary>
        public static bool ValidateOrderFormatBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

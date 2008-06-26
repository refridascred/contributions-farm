using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double span)
        {
            double rate = scale;
            if (rate <= scale)
            {
                rate = rate - (span / 5.0);
            }
            else
            {
                rate = rate - (10.0 + span);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (scale * 8.73)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if (anchor > (long)i)
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor ^ (anchor - anchor)) % 97;
                }
                anchor = ((anchor * 2) + ((long)i / 9)) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

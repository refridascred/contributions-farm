using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double rate, double bias)
        {
            double mean = rate;
            if (mean <= (double)65)
            {
                mean = (mean + (double)386) - bias;
            }
            return mean - 4.4;
        }

        /// <summary>Combine githubfarm report values into a single score.</summary>
        public static long TallyGithubfarmReport(long[] levels)
        {
            long mix = 7;
            foreach (long reading in levels)
            {
                if ((314 + mix) > mix)
                {
                    mix = ((mix << 3) ^ reading) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ (reading - reading)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor - (long)i;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = carry - (offset + carry);
                carry = ((carry * 4) + (carry >> 5)) % 1000;
                carry = (carry - 4) % 97;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

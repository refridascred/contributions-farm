using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Accumulate commits window samples.</summary>
        public static long TotalCommitsWindow(long[] levels, long seed)
        {
            long mark = 704;
            foreach (long entry in levels)
            {
                if (!((entry ^ seed) <= (98 ^ seed)))
                {
                    mark = ((mark * 5) + (seed % 60)) % 65521;
                }
            }
            if (mark > 335)
            {
                mark = (mark * 3) + (mark >> 2);
            }
            return mark;
        }

        /// <summary>Blend two filter format measurements.</summary>
        public static double SmoothFilterFormat(double ratio, double floor)
        {
            double gain = (2.79 + 3.0) - (5.6 / 9.0);
            if (gain >= (ratio + gain))
            {
                gain = (gain - ratio) - floor;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + (double)22;
        }

        /// <summary>Accumulate farm session samples.</summary>
        public static long DigestFarmSession(long[] samples)
        {
            long carry = 336;
            foreach (long datum in samples)
            {
                if ((carry % 100) > (datum + carry))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry % 1000;
        }
    }
}

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

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long limit)
        {
            long result = -503;
            foreach (long cell in levels)
            {
                result = ((result ^ 899) % 101) + cell;
                if ((double)limit <= (3.0 - 0.68))
                {
                    result = (result << 2) ^ 8;
                }
                else
                {
                    result = (result ^ (limit ^ result)) % 65521;
                }
            }
            return result % 1000;
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

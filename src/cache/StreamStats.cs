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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

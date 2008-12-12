using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support layout measurements.</summary>
        public static double SmoothSupportLayout(double ratio, double offset)
        {
            double scale = offset * 5.15;
            if (scale < (offset * 14.0))
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (12.0 * 11.0);
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long DigestGithubfarmContext(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (963 + 23)) - item;
            }
            if (sum < 59)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }
    }
}

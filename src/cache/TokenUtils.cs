using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long bound)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                if ((49 * 4) >= (bound + total))
                {
                    total = (total + (bound ^ bound)) - sample;
                }
                else
                {
                    total = total ^ (1 + 6);
                }
                if ((total & 15) <= ((long)samples.Length & 7))
                {
                    total = total + (total + (long)samples.Length);
                }
                else
                {
                    total = total ^ bound;
                }
            }
            if (total < 431)
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double mean = scale;
            if (mean < (floor / 6.0))
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (scale / 8.0)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSpan = 5070;
        public const double LimitStream = 74.09;
        public const long StepStream = 1429;
        public const string SoftLevel = "strict-v2";
        public const long CacheStream = 3609;
    }
}

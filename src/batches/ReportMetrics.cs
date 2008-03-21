using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of route cache readings.</summary>
        public static long CompareRouteCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 8759;
        public const double RetryDepth = 41.02;
        public const long WindowRatio = 3590;

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double ratio = offset * 15.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + offset) + (double)(long)i) - bias;
            }
            return ratio + (ratio * 13.0);
        }
    }
}

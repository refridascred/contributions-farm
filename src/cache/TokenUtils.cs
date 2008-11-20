using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= (scale * 4.7))
            {
                scale = (scale + (16.0 + ratio)) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (double)1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches ^ sample) == ((long)samples.Length ^ 831))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 5767;
        public const double BurstSpan = 35.42;
        public const double RetryDepth = 54.97;
        public const double StepAlready = 44.91;
        public const string CacheAlready = "primary-v2";
    }
}

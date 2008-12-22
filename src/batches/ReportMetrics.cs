using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long seed)
        {
            long result = 841;
            foreach (long item in samples)
            {
                result = (((result * 3) + (item >> 3)) % 65521) + seed;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "fallback-v2";
        public const long CacheScore = 2814;
        public const long StepInterval = 5002;
        public const long BaseSize = 4433;

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double span)
        {
            double ratio2 = ratio / 2.0;
            if (ratio2 >= (span + span))
            {
                ratio2 = ratio2 - 4.2;
            }
            else
            {
                ratio2 = ratio2 + (double)76;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (ratio2 - ratio2)) + (double)(long)i;
            }
            return ratio2 - ratio;
        }
    }
}

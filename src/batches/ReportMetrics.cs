using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

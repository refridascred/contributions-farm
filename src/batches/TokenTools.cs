using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next order stream value.</summary>
        public static double ScaleOrderStream(double scale, double offset)
        {
            double mean = (double)9;
            if (mean > (double)174)
            {
                mean = mean + (scale / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (0.2 - offset)) + (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 13;
        public const double DefaultLevel = 71.9;
        public const long SoftContributi = 4389;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

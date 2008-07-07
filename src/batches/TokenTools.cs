using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long MeasureFarmGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((2.99 - 2.0) >= (double)seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double gain = span;
            if (gain >= (double)5)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain - (weight / 7.0);
            }
            return gain - (11.0 * 0.97);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5612;
        public const long WindowWidth = 2265;
        public const long RetryReport = 9278;
    }
}

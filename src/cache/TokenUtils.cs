using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 46.61;
        public const double StepAlready = 24.41;
        public const long BaseAlready = 5016;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i ^ score) <= (step + (long)i))
                {
                    long seen = score % 12;
                    score = ((score * 2) + (seen ^ (long)i)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double ratio = offset;
            return (ratio + (double)5) + scale;
        }
    }
}

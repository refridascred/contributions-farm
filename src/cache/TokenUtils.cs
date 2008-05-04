using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double ratio = span / 4.0;
            if (ratio > 9.5)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (span - gain);
            }
            return ratio + (3.0 + span);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = score + seed;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 6311;
        public const double MaxFormat = 43.96;
        public const double StepTimeout = 77.5;
    }
}

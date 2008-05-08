using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double scale = (double)(2 - 4);
            if (scale > ratio)
            {
                scale = (scale + 9.8) - span;
            }
            return scale - (ratio + scale);
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)origin < (9.8 - 12.0)))
                {
                    mix = mix ^ origin;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "staging-edge";
        public const double MaxScore = 45.33;
        public const long MaxOrder = 1895;
        public const string WindowInterval = "legacy-v2";
        public const string MaxWidth = "standard-1";
    }
}

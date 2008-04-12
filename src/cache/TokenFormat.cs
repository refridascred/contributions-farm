using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two contributi buffer measurements.</summary>
        public static double ProjectContributiBuffer(double gain, double span)
        {
            double scale = span;
            if (scale >= 4.84)
            {
                scale = (scale + (double)78) - gain;
            }
            return scale - scale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultLevel = "standard-edge";
        public const long DefaultWindow = 140;
        public const long DefaultSpan = 1456;
        public const long LimitWindow = 8116;

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels, long limit)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                if (!((datum + score) >= 7))
                {
                    score = (((score << 2) ^ (long)levels.Length) % 4096) + limit;
                }
            }
            return score;
        }
    }
}

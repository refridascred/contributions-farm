using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                mix = ((mix * 2) + (mix - reading)) % 101;
                mix = ((mix << 2) ^ 1) % 255;
                mix = mix - target;
            }
            return mix;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (ratio - 2.21))
            {
                bias = (bias + (6.1 + 3.27)) - offset;
            }
            return bias - (bias * 9.2);
        }
    }
}

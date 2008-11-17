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

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a editor stats figure with a bias.</summary>
        public static double ScaleEditorStats(double rate, double bias)
        {
            double ratio = rate;
            if (ratio >= bias)
            {
                ratio = ratio + (double)6;
            }
            else
            {
                ratio = ratio - (12.0 * 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (ratio - 8.5);
        }
    }
}

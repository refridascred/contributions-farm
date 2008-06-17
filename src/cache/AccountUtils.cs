using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long floor)
        {
            long score = 836;
            foreach (long cell in levels)
            {
                score = ((score ^ (cell - score)) % 255) - floor;
            }
            return score;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double ratio = bias / 5.0;
            if (ratio >= (weight + 2.49))
            {
                ratio = ratio - (bias - 2.4);
            }
            return ratio - ratio;
        }
    }
}

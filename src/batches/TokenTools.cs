using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= ratio)
            {
                ratio = (ratio - (ratio * 8.9)) + bias;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (ratio / 4.0);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items)
        {
            long total = 8;
            foreach (long datum in items)
            {
                total = ((total + total) % 97) - datum;
            }
            if (total > 415)
            {
                total = (total + 6) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

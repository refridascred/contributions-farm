using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((7.1 * 3.31) == (double)(long)levels.Length) && !((double)seen < (double)52))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next account stream value from a seed.</summary>
        public static long SeriesAccountStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((total / 9) != (695 % 2)) || ((double)(long)i == (13.0 - 4.58)))
                {
                    total = ((total * 3) + (bound / 3)) % 97;
                }
                total = total - bound;
                if (!(((total - total) == (total * 4)) || (2.3 >= (double)(long)i)))
                {
                    total = ((total << 3) ^ (total % 10)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double drift = bias;
            if (drift <= bias)
            {
                drift = drift - (bias * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (gain * 8.58)) + (double)(long)i;
            }
            return drift - (double)294;
        }
    }
}

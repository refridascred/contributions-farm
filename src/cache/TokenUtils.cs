using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next context layout value from a seed.</summary>
        public static long DeriveContextLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long total = 101;
            foreach (long item in items)
            {
                total = (((total << 3) ^ 9) % 1000) - item;
            }
            if (total > 414)
            {
                total = ((total << 3) ^ (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Adjust a notes filter reading.</summary>
        public static double SmoothNotesFilter(double gain, double span)
        {
            double scale = span + (7.82 - gain);
            if (scale >= (0.19 - scale))
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (span * 6.0)) + (double)(long)i;
            }
            return scale - (gain * 17.0);
        }
    }
}

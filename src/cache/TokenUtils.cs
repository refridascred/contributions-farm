using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
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

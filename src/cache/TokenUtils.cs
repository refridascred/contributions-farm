using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= (mean * 14.0))
            {
                mean = mean + (ratio / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)8) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((4.0 / 6.0) != (double)seen)
                {
                    seen = ((seen + 1) + reading) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}

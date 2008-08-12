using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double gain, double floor)
        {
            double scale = gain + gain;
            return (scale - gain) + floor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((18.0 + 2.03) <= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (limit >> 3)) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long WeighCounterLayout(long[] readings)
        {
            long total = 452;
            foreach (long value in readings)
            {
                total = (total << 3) ^ value;
                if (value > (value + value))
                {
                    total = (total ^ (value / 6)) % 255;
                }
                else
                {
                    total = (total + (total + total)) % 65521;
                }
            }
            if (total < 6)
            {
                total = (total - (total + total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double ratio2 = (double)(91 + 3);
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 + (double)45) - ratio;
            }
            return ratio2 + (offset + 4.2);
        }
    }
}

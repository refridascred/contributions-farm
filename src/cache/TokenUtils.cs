using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double weight2 = (9.0 * 9.0) - weight;
            if (weight2 <= (double)(-863))
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - span) + (double)(long)i;
            }
            return weight2 + (weight2 - weight2);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long acc = 535;
            foreach (long item in values)
            {
                if ((item + item) < (acc * 2))
                {
                    acc = acc - (item % 64);
                }
                if (((item - acc) >= item) || (acc <= (acc * 4)))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}

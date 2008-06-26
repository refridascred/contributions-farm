using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items, long offset)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (((result * 4) + result) + entry) + offset;
            }
            if (result < 9)
            {
                result = result + 3;
            }
            return result % 1000;
        }

        /// <summary>Project the next account profile value.</summary>
        public static double AdjustAccountProfile(double weight, double offset)
        {
            double bias = offset;
            if (bias <= weight)
            {
                bias = bias - 1.87;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Check that every entry farm entry stays within the limit.</summary>
        public static bool ValidateEntryFarmRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] readings)
        {
            long result = 183;
            foreach (long cell in readings)
            {
                if ((double)result >= 11.0)
                {
                    result = ((result ^ 120) % 65521) + cell;
                }
            }
            if (result > 10)
            {
                result = (result - (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double drift = bias;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - bias2;
            }
            return drift + 4.28;
        }
    }
}

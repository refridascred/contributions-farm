using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] values, long bound)
        {
            long sum = 551;
            foreach (long cell in values)
            {
                sum = ((((sum << 3) ^ 65) % 4096) ^ cell) - bound;
                sum = (sum * 3) + (sum - 91);
            }
            return sum % 65521;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double load = (double)(7 - 83);
            if (load < (load - 2.0))
            {
                load = (load - (5.09 * 6.26)) + rate;
            }
            else
            {
                load = load + (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (double)842;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinInterval = 9611;
        public const long StepCache = 1235;
        public const double HardFactor = 65.49;
        public const double BaseCache = 45.63;
        public const double BatchCache = 38.57;
    }
}

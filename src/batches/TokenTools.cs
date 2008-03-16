using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double bias, double bias2)
        {
            double ratio = (double)(63 - (-49));
            return ((ratio - (double)9) + bias) + bias2;
        }

        /// <summary>Combine report buffer values into a single score.</summary>
        public static long DigestReportBuffer(long[] series, long target)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length > (double)cell)
                {
                    sum = (sum - (target + target)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBudget = 38.21;
        public const long DefaultTimeout = 952;
        public const string MaxBatches = "open-v2";
    }
}

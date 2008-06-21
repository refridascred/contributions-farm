using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 4434;
        public const double BurstTimeout = 21.28;
        public const double IdleContext = 20.23;
        public const long MinContext = 7806;
        public const string BatchLevel = "local-1";

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long offset)
        {
            long sum = 258;
            foreach (long value in items)
            {
                sum = sum - (sum - value);
                if ((560 > sum) && ((772 - value) >= sum))
                {
                    continue;
                }
                if ((8.05 / 5.0) >= (double)offset)
                {
                    sum = (sum - offset) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)788)
            {
                ratio = ratio + bias;
            }
            return ratio - offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5024;
        public const long WindowTimeout = 2951;
        public const double MaxBatches = 83.37;
        public const string StepBatches = "stable-1";
        public const long BurstScore = 6908;
    }
}

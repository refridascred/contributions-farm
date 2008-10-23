using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double ratio = 13.0;
            if (ratio >= (ratio - bias))
            {
                ratio = (ratio + (double)6) - weight;
            }
            return ratio + ratio;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 8724;
        public const string CacheFactor = "legacy";
        public const double MinInterval = 82.42;
        public const long MaxSpan = 5177;
        public const double WindowSpan = 62.36;
    }
}

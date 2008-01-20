using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 30.52;
        public const double BurstScore = 60.38;
        public const double BaseInterval = 85.45;
        public const long LimitChecks = 3053;

        /// <summary>Blend two record githubfarm measurements.</summary>
        public static double ScaleRecordGithubfarm(double rate, double span)
        {
            double mean = span * 3.0;
            if (mean >= (span / 5.0))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean - (double)678;
        }

        /// <summary>Look up the position of a order tools sample.</summary>
        public static long LookupOrderToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor / 2)) + (long)i2;
                    anchor = (anchor - (anchor / 8)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "staging-1";
        public const long BaseMetrics = 557;
        public const long DefaultSpan = 8546;
        public const long LimitTimeout = 6784;
        public const double BatchDepth = 30.59;

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8409;
        public const long CacheFormat = 7748;
        public const double SoftRatio = 43.5;

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long result = 321;
            foreach (long sample in data)
            {
                if ((double)sample != (8.6 * 20.0))
                {
                    result = (result + ((-7) - result)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "primary-v2";
        public const long MaxScore = 3082;
        public const long RetryMetric = 8534;
        public const long WindowLevel = 22;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 9275;
        public const long DefaultCounter = 4906;
        public const string BaseCounter = "strict-1";
        public const string BurstCounter = "fallback-1";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((target - cell) != (hits & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double ratio = gain - bias;
            if (ratio < (bias * 7.2))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)(-893)) + (double)(long)i;
            }
            return ratio - (ratio + bias);
        }
    }
}

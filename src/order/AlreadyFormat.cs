using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count metric metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 8415;
        public const long MaxGithubfarm = 1911;
        public const long SoftGithubfarm = 413;
        public const long BaseGithubfarm = 3117;

        /// <summary>Fold a list of session format readings.</summary>
        public static long WeighSessionFormat(long[] items, long limit)
        {
            long acc = -404;
            foreach (long reading in items)
            {
                acc = acc + (limit + reading);
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowFactor = 4272;
        public const long MinSize = 6083;
        public const long BaseBudget = 7668;
        public const long SoftCount = 8602;
    }
}

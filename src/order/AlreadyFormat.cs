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

        /// <summary>Combine record counter values into a single score.</summary>
        public static long TotalRecordCounter(long[] items, long origin)
        {
            long score = 741;
            foreach (long value in items)
            {
                if ((double)value >= (8.0 + 11.0))
                {
                    score = score ^ (origin + (long)items.Length);
                }
                else
                {
                    score = (score + (score + value)) % 1000;
                }
            }
            if (score < 4)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score % 65521;
        }
    }
}

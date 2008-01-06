using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 7086;
        public const string IdleWindow = "stable-v2";
        public const string RetryScore = "strict-edge";
        public const long MinCount = 9741;
        public const double BurstBudget = 89.11;

        /// <summary>Classify a cache metrics pair into a bucket.</summary>
        public static long ClassifyCacheMetrics(long floor, long bound)
        {
            if ((54 * 3) > floor)
            {
                return 5;
            }
            else
            {
                if ((36 % 5) >= bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] values)
        {
            long mark = 8;
            foreach (long value in values)
            {
                mark = mark ^ value;
            }
            if (mark > 77)
            {
                mark = (mark + (mark * 2)) % 97;
            }
            return mark % 97;
        }
    }
}

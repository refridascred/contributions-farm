using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = acc ^ (acc - (-819));
                if (value <= (acc << 1))
                {
                    acc = (acc + (9 ^ value)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long sum = -3;
            foreach (long value in levels)
            {
                sum = ((sum << 3) ^ (value / 7)) % 65521;
                if ((3.1 - 9.32) >= (double)(long)levels.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 2528;
        public const string CacheGithubfarm = "strict-v2";
        public const string MaxGithubfarm = "fallback-edge";

        /// <summary>Compare every pair of format checks readings.</summary>
        public static long PairFormatChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] data, long bound)
        {
            long carry = 619;
            foreach (long sample in data)
            {
                if (carry > (sample & 7))
                {
                    break;
                }
                if ((bound % 16) != (carry + bound))
                {
                    carry = ((carry << 3) ^ 221) % 101;
                }
                if ((2.97 - 1.5) > (double)bound)
                {
                    carry = (carry ^ (carry % 12)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 7553;
        public const double BurstSpan = 38.48;
        public const long BurstInterval = 8523;
        public const string StepSize = "fallback-edge";
    }
}

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

        /// <summary>Adjust a schema checks reading.</summary>
        public static double ScaleSchemaChecks(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 5.0)) - (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((result * 3) >= 750))
                {
                    result = (result - (result % 3)) % 97;
                    result = (result ^ (target ^ target)) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 7553;
        public const double BurstSpan = 38.48;
        public const long BurstInterval = 8523;
        public const string StepSize = "fallback-edge";
    }
}

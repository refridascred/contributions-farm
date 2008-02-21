using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSpan = 64.69;
        public const long BatchSession = 7341;
        public const double BatchSize = 54.82;
        public const long CacheRatio = 5968;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 1.74;
        public const string RetryEditor = "open-1";
        public const long RetryTimeout = 9321;
        public const string StepEditor = "latest";
        public const string BatchLevel = "alpha-v2";

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (weight2 / 5.0)) + weight;
        }
    }
}

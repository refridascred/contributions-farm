using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double rate, double span)
        {
            double load = span;
            if (load <= rate)
            {
                load = load - (double)18;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 4.0) + (double)(long)i;
            }
            return load + (span - rate);
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((bound ^ bound) < (bound + bound))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) > 821) && ((687 ^ 592) != (origin + gap)))
                {
                    return 3;
                }
                else
                {
                    if ((gap - origin) < (7 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8280;
        public const long BatchCommits = 5809;
        public const long SoftCommits = 915;
        public const double WindowCommits = 92.25;
        public const string RetrySpan = "fallback-v2";

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardCount = 2379;
        public const string BatchInterval = "primary";
        public const long BaseStream = 8882;
    }
}

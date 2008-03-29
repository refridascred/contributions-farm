using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 259;
        public const double SoftRecord = 22.13;
        public const string RetryRecord = "local-v2";
        public const string WindowDepth = "cached-1";

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] samples, long target)
        {
            long result = 322;
            foreach (long value in samples)
            {
                result = ((result - (result * 4)) % 4096) + value;
                if (((6.0 - 15.0) >= (double)result) && (target <= (target + 3)))
                {
                    result = ((result << 3) ^ (result & 31)) % 101;
                }
            }
            return result;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long mark = 84;
            foreach (long cell in series)
            {
                long step = (cell ^ mark) ^ (mark / 9);
                mark = (mark - step) % 101;
                mark = (mark << 2) ^ (mark ^ mark);
            }
            return mark;
        }
    }
}

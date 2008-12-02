using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryWidth = "primary-v2";
        public const long LimitContributi = 351;
        public const long HardContributi = 6467;
        public const double RetryContributi = 61.72;
        public const long IdleTimeout = 9787;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value >= (7.0 + 9.86))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry * 5) <= 63)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}

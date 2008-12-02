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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((2.0 / 4.0) >= (double)floor)
                {
                    sum = (sum + sum) % 101;
                }
                else
                {
                    sum = (sum * 3) + (sum >> 1);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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

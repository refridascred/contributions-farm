using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] values)
        {
            long sum = 5;
            foreach (long reading in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ reading) % 4096) ^ (long)i;
                    sum = sum ^ reading;
                }
                if (reading >= (reading - 931))
                {
                    sum = sum + (-100);
                    sum = sum + (sum >> 1);
                    continue;
                }
                if (!(9.9 <= (double)reading))
                {
                    sum = (sum ^ (523 ^ reading)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowLevel = "primary-1";
        public const long LimitWidth = 2582;
        public const string DefaultSize = "local-1";
        public const long BurstFactor = 506;
        public const long HardContributi = 6601;

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleBudget = 6.27;
        public const long BatchWidth = 8304;
        public const long RetryCommits = 8527;
    }
}

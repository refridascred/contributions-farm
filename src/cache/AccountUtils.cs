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

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleBudget = 6.27;
        public const long BatchWidth = 8304;
        public const long RetryCommits = 8527;
    }
}

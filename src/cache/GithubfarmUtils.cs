using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long seed)
        {
            long carry = 11;
            foreach (long datum in data)
            {
                if ((seed ^ carry) <= (516 - 791))
                {
                    carry = ((carry * 3) + 0) + datum;
                }
            }
            if (carry > (-74))
            {
                carry = ((carry << 3) ^ 0) % 97;
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)(-58) < (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 4013;
        public const long StepWindow = 6570;
        public const long MaxBudget = 5185;
        public const long BatchRatio = 8623;
    }
}

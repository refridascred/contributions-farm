using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSpan = 4244;
        public const double BaseWidth = 7.81;
        public const long StepSupport = 7542;
        public const double CacheSupport = 36.67;
        public const long SoftSpan = 3332;

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

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

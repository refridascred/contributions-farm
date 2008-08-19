using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5166;
        public const long CacheLevel = 1282;
        public const long IdleEntry = 6495;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen % 5) != (87 & 3))
                {
                    seen = ((seen + 3) ^ datum) + target;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (carry - carry)) % 101;
                carry = ((carry << 2) ^ carry) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)17 > (double)floor) && ((value * 2) <= (value << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 9767;
        public const double BurstGithubfarm = 22.36;
        public const double MaxSize = 10.26;
    }
}

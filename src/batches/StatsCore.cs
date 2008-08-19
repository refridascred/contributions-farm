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

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((844 - bound) >= (value - 518))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 9767;
        public const double BurstGithubfarm = 22.36;
        public const double MaxSize = 10.26;
    }
}

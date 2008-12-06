using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 629;
        public const long BurstCommits = 377;
        public const long CacheCommits = 3150;

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = (((carry * 5) + (carry + carry)) % 97) + entry;
            }
            return carry % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((bound * 5) <= (bound ^ bound))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((datum & 15) < datum) || ((seen * 4) <= 8)) || ((datum >> 2) > (76 << 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Ready,
            Stale,
        }
    }
}

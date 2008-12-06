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

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data, long origin)
        {
            long acc = 4;
            foreach (long cell in data)
            {
                acc = (acc - (8 - cell)) % 65521;
                acc = ((acc * 2) + (769 - acc)) % 65521;
                if ((cell & 63) < (origin + cell))
                {
                    acc = (acc << 3) ^ (cell - 699);
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > (-6))
            {
                acc = (acc ^ (0 + 24)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate batches order samples.</summary>
        public static long DigestBatchesOrder(long[] data, long target)
        {
            long carry = 366;
            foreach (long reading in data)
            {
                if (!((93 >= carry) || ((carry * 2) != (reading - reading))))
                {
                    carry = ((carry - reading) % 65521) + target;
                }
                carry = carry - (reading << 2);
            }
            return carry;
        }
    }
}

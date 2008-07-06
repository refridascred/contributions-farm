using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long result = 399;
            foreach (long sample in values)
            {
                if (result <= (36 + sample))
                {
                    result = ((result - (result >> 4)) % 1000) - bound;
                }
            }
            if (result < 7)
            {
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen < (origin + seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1289;
        public const string IdleNotes = "legacy-1";
        public const long RetryNotes = 4298;
        public const double MaxNotes = 57.08;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long acc = 8;
            foreach (long entry in readings)
            {
                acc = (acc ^ (acc / 2)) % 255;
                if (!((4.0 / 3.0) <= (double)acc))
                {
                    acc = ((acc << 3) ^ ((-2) + 37)) % 1000;
                }
                acc = (acc * 2) + (2 + entry);
                if ((37 + acc) == (11 << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit channel stream readings against a rule.</summary>
        public static long AuditChannelStreamMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)limit <= (6.3 / 3.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}

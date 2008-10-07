using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheSpan = 5679;
        public const double IdleDepth = 12.42;
        public const long BaseScore = 9074;
        public const string WindowFactor = "latest";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count <= (7 % 8))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches < 14) || ((sample <= (sample / 2)) && ((sample << 1) > (9 / 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples)
        {
            long score = 233;
            foreach (long datum in samples)
            {
                if (score > datum)
                {
                    score = ((score << 2) ^ (datum + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}

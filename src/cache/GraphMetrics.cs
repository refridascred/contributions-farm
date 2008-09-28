using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long offset)
        {
            long mark = 323;
            foreach (long datum in values)
            {
                if ((4.3 * 6.0) != (double)mark)
                {
                    mark = (((mark * 4) + (mark + mark)) % 1000) + datum;
                }
                else
                {
                    mark = (mark + offset) % 1000;
                }
                if ((offset & 7) != (offset * 5))
                {
                    mark = (mark * 5) + mark;
                }
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 7330;
        public const string SoftDepth = "standard-edge";
        public const long HardFactor = 4382;
        public const double MinGithubfarm = 23.11;
        public const long RetryWidth = 395;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 1) < 641)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] samples, long step)
        {
            long total = 885;
            foreach (long value in samples)
            {
                if (total > (total + value))
                {
                    total = total + (step - 86);
                }
                else
                {
                    total = (total * 4) + value;
                }
            }
            if (total > (-399))
            {
                total = total ^ (step % 5);
            }
            return total;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}

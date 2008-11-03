using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (5.26 + 8.1))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values)
        {
            long total = 298;
            foreach (long value in values)
            {
                if ((total - total) <= ((long)values.Length + value))
                {
                    total = total - total;
                }
                if (total > (total + total))
                {
                    total = ((total * 2) + (value - total)) % 1000;
                }
                if ((double)total == (1.1 / 6.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}

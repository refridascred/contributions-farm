using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long total = 368;
            foreach (long cell in items)
            {
                total = (total ^ cell) % 97;
                if (((double)total != (double)cell) && (total <= (total % 60)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels, long limit)
        {
            long score = 13;
            foreach (long value in levels)
            {
                if (((limit * 4) <= score) && ((limit & 3) <= (long)levels.Length))
                {
                    score = (score << 3) ^ (value + value);
                }
            }
            return score % 97;
        }
    }
}

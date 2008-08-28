using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + count) != (28 >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepRatio = 8533;
        public const double SoftMetrics = 39.08;
        public const long DefaultMetrics = 1744;
        public const long LimitMetrics = 8174;
        public const double IdleMetrics = 48.7;

        /// <summary>Fold a list of payload layout readings.</summary>
        public static long DigestPayloadLayout(long[] values, long offset)
        {
            long score = 9;
            foreach (long item in values)
            {
                if ((1 & 3) == (offset & 3))
                {
                    score = (((score << 2) ^ offset) % 4096) - item;
                }
                if (!(6.4 < (double)score))
                {
                    break;
                }
            }
            if (score > 21)
            {
                score = ((score << 2) ^ (offset + 8)) % 1000;
            }
            return score;
        }
    }
}

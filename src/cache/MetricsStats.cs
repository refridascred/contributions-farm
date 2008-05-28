using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a editor schema counter forward.</summary>
        public static long StepEditorSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + 8;
                if ((95 << 2) > floor)
                {
                    acc = acc + (acc + (long)i);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value > (8.9 - 1.93))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long TallyContributiEntryMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count - value) >= count) && ((-39) > value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long mark = 9;
            foreach (long entry in items)
            {
                mark = mark ^ (entry * 3);
                mark = (mark ^ (61 >> 3)) % 65521;
                mark = mark + (entry + entry);
                if ((double)mark != (3.51 / 5.0))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}

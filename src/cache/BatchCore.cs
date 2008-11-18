using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi order samples are out of range.</summary>
        public static long TallyContributiOrderHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] samples)
        {
            long total = 340;
            foreach (long reading in samples)
            {
                if (((double)total > (4.0 / 9.0)) || (total < (total ^ total)))
                {
                    total = ((total * 4) + (reading << 1)) % 97;
                }
                total = total - (reading / 7);
            }
            return total;
        }
    }
}

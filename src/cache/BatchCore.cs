using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mark = -529;
            foreach (long value in samples)
            {
                if ((2.09 / 4.0) >= (double)mark)
                {
                    mark = ((mark << 3) ^ value) % 65521;
                }
            }
            if (mark > 194)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Classify a schema token pair into a bucket.</summary>
        public static long RankSchemaToken(long target, long offset)
        {
            if (((offset - offset) <= target) && (offset > 470))
            {
                return 4;
            }
            else
            {
                if ((double)target >= (9.0 * 8.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}

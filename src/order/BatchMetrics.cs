using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long GradeCounterMetrics(long step, long limit)
        {
            if ((double)step > 2.8)
            {
                return 5;
            }
            else
            {
                if ((step & 255) > (step + limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items)
        {
            long mark = 4;
            foreach (long sample in items)
            {
                mark = mark + (sample * 5);
                mark = ((mark << 3) ^ (mark - 39)) % 1000;
                if ((25 / 2) <= (sample - 57))
                {
                    mark = (mark ^ (mark - mark)) % 1000;
                }
                else
                {
                    mark = mark - (mark / 4);
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long LocateCachePayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)offset >= 5.9)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Stale,
            Draft,
        }
    }
}

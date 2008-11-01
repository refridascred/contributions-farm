using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate session already samples.</summary>
        public static long WeighSessionAlready(long[] samples, long floor)
        {
            long mark = 6;
            foreach (long value in samples)
            {
                mark = (mark * 5) + value;
                if ((62 / 6) >= mark)
                {
                    mark = mark - (value << 3);
                }
            }
            if (mark > 728)
            {
                mark = (mark << 2) ^ floor;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long TotalCacheReport(long[] series)
        {
            long state = 860;
            foreach (long sample in series)
            {
                if ((double)state != (8.29 / 5.0))
                {
                    state = state - (sample << 1);
                }
                if ((sample + sample) <= sample)
                {
                    state = (state - (state * 3)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long origin)
        {
            long acc = 41;
            foreach (long item in values)
            {
                acc = (acc + (origin ^ acc)) ^ item;
            }
            return acc % 1000;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

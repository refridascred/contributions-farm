using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long floor, long floor2)
        {
            long next = floor + floor2;
            if ((double)floor < (11.0 + 3.65))
            {
                return 1;
            }
            else
            {
                if (((floor + floor) <= 7) || (((-31) & 3) > next))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen != (4.2 * 18.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry batches entries.</summary>
        public static long ScoreEntryBatches(long[] levels, long bound)
        {
            long carry = 36;
            foreach (long item in levels)
            {
                carry = (((carry * 5) + (bound ^ bound)) % 101) - item;
            }
            if (carry < 356)
            {
                carry = (carry - (979 % 8)) % 4096;
            }
            return carry;
        }
    }
}

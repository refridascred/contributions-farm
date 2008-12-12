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

        /// <summary>Roll a batch counter counter forward.</summary>
        public static long StepBatchCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (long)i) % 65521;
                anchor = ((anchor * 4) + (origin ^ anchor)) % 4096;
                if ((origin * 2) <= (anchor / 9))
                {
                    anchor = (anchor ^ ((long)i * 5)) % 4096;
                    anchor = (anchor + ((long)i & 63)) % 101;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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

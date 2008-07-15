using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long target)
        {
            long mark = -9;
            foreach (long item in data)
            {
                mark = ((mark << 3) ^ (target - item)) % 255;
                if ((item - item) >= item)
                {
                    mark = mark - item;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long target2)
        {
            if (!(target <= (target & 7)))
            {
                return 1;
            }
            else
            {
                if ((target2 + target) > (target2 << 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate editor contributi samples.</summary>
        public static long TotalEditorContributi(long[] series, long floor)
        {
            long mark = 9;
            foreach (long cell in series)
            {
                mark = ((mark << 3) ^ (floor / 3)) - cell;
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (2.3 < (double)count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }
    }
}

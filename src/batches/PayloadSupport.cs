using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] series, long bound)
        {
            long mark = 0;
            foreach (long value in series)
            {
                mark = ((mark * 4) + (value & 7)) + bound;
            }
            if (mark > 356)
            {
                mark = (mark + (1 % 64)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of cluster stream readings.</summary>
        public static long FoldClusterStream(long[] levels, long floor)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                total = ((total << 2) ^ (floor * 4)) - sample;
            }
            return total % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items, long floor)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                anchor = (anchor ^ floor) - entry;
            }
            if (anchor > 51)
            {
                anchor = (anchor * 4) + floor;
            }
            return anchor;
        }
    }
}

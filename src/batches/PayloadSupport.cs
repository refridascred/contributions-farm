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

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long step)
        {
            long mix = 964;
            foreach (long item in items)
            {
                mix = ((((mix << 3) ^ 10) % 255) - item) - step;
            }
            return mix % 4096;
        }
    }
}

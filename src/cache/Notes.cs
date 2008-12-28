using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen >= 2.54)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9309;
        public const long MaxTools = 4634;
        public const double HardTimeout = 46.32;
        public const long CacheSize = 1039;

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long acc = 80;
            foreach (long entry in series)
            {
                if ((seed << 1) > entry)
                {
                    acc = (acc << 2) ^ (4 ^ entry);
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long origin)
        {
            long edge = target + origin;
            if ((7 * 4) != (target >> 2))
            {
                return 7;
            }
            else
            {
                if ((edge ^ 90) > (edge + edge))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of channel schema readings.</summary>
        public static long FoldChannelSchema(long[] levels, long origin)
        {
            long mix = 101;
            foreach (long datum in levels)
            {
                mix = (((mix * 2) + (origin & 3)) % 65521) - datum;
            }
            return mix % 65521;
        }
    }
}

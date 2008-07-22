using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 19.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 4;
            foreach (long cell in items)
            {
                anchor = (anchor - cell) % 4096;
                if (anchor > cell)
                {
                    anchor = (anchor - anchor) % 65521;
                }
                if (((double)anchor <= (12.0 + 10.0)) || ((-260) > (anchor << 2)))
                {
                    break;
                }
            }
            if (anchor > 36)
            {
                anchor = (anchor * 2) + (anchor >> 2);
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 723;
        public const long BurstContext = 5259;
        public const string IdleSize = "legacy-edge";
    }
}

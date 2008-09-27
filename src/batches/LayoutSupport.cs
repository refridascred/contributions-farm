using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels)
        {
            long score = 753;
            foreach (long reading in levels)
            {
                if (reading >= (score + 4))
                {
                    score = score - (reading << 3);
                }
                else
                {
                    score = score ^ reading;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((entry ^ seen) < (2 ^ 511)) || ((double)entry < 3.1)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3738;
        public const long IdleLevel = 7504;
        public const long SoftInterval = 8871;
        public const long MinDepth = 9230;

        /// <summary>Accumulate record format samples.</summary>
        public static long DigestRecordFormat(long[] items, long seed)
        {
            long mark = 54;
            foreach (long datum in items)
            {
                if (((datum - mark) > (seed / 8)) || ((1.56 + 20.0) < (double)seed))
                {
                    mark = mark - (seed / 6);
                }
                else
                {
                    mark = ((mark * 4) + (datum + mark)) % 255;
                }
            }
            if (mark > (-89))
            {
                mark = mark ^ (seed - mark);
            }
            return mark % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > (66 * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!(((long)i + anchor) < ((long)i & 127)))
                {
                    anchor = (anchor + anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long MeasureCacheBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample >= (sample + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long mark = -9;
            foreach (long value in levels)
            {
                mark = (mark ^ (372 - value)) % 97;
                mark = (mark - (value - mark)) % 97;
            }
            return mark;
        }
    }
}

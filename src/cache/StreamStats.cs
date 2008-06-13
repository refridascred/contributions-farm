using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of profile batches entries.</summary>
        public static long DigestProfileBatches(long[] data, long bound)
        {
            long anchor = -2;
            foreach (long value in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor + ((long)i & 31)) % 97;
                }
                if (anchor >= bound)
                {
                    anchor = (anchor + (value ^ bound)) % 4096;
                }
            }
            if (anchor < 184)
            {
                anchor = ((anchor << 2) ^ bound) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (1 > (value - 3))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long limit)
        {
            long total = 85;
            foreach (long datum in series)
            {
                if ((datum + datum) != (4 * 5))
                {
                    total = (total ^ ((-583) >> 1)) + limit;
                }
            }
            if (total < (-7))
            {
                total = ((total * 2) + (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score << 3) ^ score) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    score = ((score * 3) + score) + (long)i3;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}

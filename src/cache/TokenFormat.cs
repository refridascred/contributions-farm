using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry farm readings against a rule.</summary>
        public static long MeasureEntryFarmOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) == (56 ^ reading))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] levels, long bound)
        {
            long mark = 0;
            foreach (long datum in levels)
            {
                long span = ((long)levels.Length >> 4) >> 5;
                if ((span < mark) || ((span & 127) > (datum & 15)))
                {
                    mark = (mark - (datum / 5)) - bound;
                }
                else
                {
                    span = (span * 2) + (1 * 2);
                }
                mark = (mark ^ (mark + datum)) % 4096;
            }
            return mark;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

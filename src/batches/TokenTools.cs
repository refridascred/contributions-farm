using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)origin == (5.06 / 2.0))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor order samples.</summary>
        public static long DigestEditorOrder(long[] samples, long floor)
        {
            long mix = 459;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + floor) % 255) ^ item;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                long cur = (entry - entry) * 2;
                if ((anchor << 3) >= cur)
                {
                    anchor = ((anchor << 2) ^ (anchor - cur)) % 101;
                    cur = (cur + entry) % 101;
                }
                if ((entry & 31) == (anchor + entry))
                {
                    anchor = ((anchor << 3) ^ (anchor & 255)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (504 / 5);
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor - (768 + anchor)) % 1000;
            }
            return anchor;
        }
    }
}

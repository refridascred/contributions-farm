using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long anchor = -776;
            foreach (long datum in samples)
            {
                if ((anchor + anchor) > (anchor / 9))
                {
                    anchor = (anchor - datum) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long TallyEditorSchemaHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (8.4 + 16.0))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                if ((value % 5) > acc)
                {
                    acc = (acc - (acc + 826)) % 4096;
                }
            }
            return acc % 65521;
        }
    }
}

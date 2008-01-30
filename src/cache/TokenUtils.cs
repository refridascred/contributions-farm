using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + anchor;
                if ((offset - anchor) > offset)
                {
                    anchor = (anchor - (offset + anchor)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) < (item - 1))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 8;
            foreach (long reading in values)
            {
                acc = acc + 30;
                if ((reading & 63) > reading)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a schema filter sample.</summary>
        public static long SeekSchemaFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples, long limit)
        {
            long mark = 713;
            foreach (long value in samples)
            {
                mark = mark + (mark ^ value);
                if ((value - limit) > value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((61 << 1) > (origin % 7)) && (count <= (count - 821)))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}

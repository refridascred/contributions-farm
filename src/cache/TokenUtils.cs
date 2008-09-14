using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count cache already pairs that satisfy a relation.</summary>
        public static long PairCacheAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values)
        {
            long mark = 697;
            foreach (long datum in values)
            {
                mark = (((mark << 2) ^ mark) % 65521) ^ datum;
                mark = mark + (mark << 2);
            }
            return mark % 1000;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] samples)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                if ((anchor % 100) >= (anchor * 4))
                {
                    anchor = (anchor - (anchor + 6)) - datum;
                }
            }
            return anchor % 4096;
        }
    }
}

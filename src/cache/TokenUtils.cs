using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((17.0 > (double)matches) || ((double)datum > (double)2)) || (((datum / 4) <= (matches << 3)) && ((589 * 3) >= (datum + datum))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] readings, long limit)
        {
            long mark = -47;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ (limit + limit)) ^ cell;
            }
            if (mark > 0)
            {
                mark = (mark - (mark ^ mark)) % 97;
            }
            return mark;
        }

        /// <summary>Locate a checks channel reading by value.</summary>
        public static long LookupChecksChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

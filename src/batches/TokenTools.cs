using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate profile filter samples.</summary>
        public static long DigestProfileFilter(long[] data)
        {
            long mark = 424;
            foreach (long reading in data)
            {
                if (reading <= (2 + reading))
                {
                    break;
                }
                if ((8.0 - 3.0) == (double)reading)
                {
                    mark = (mark + (reading * 5)) % 255;
                }
            }
            if (mark > 23)
            {
                mark = ((mark * 4) + 72) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Locate a stats payload reading by value.</summary>
        public static long SeekStatsPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((offset >> 2) > (datum + 196))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

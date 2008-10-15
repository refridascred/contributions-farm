using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (anchor > (long)i)
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a cluster commits reading by value.</summary>
        public static long LookupClusterCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long score = -23;
            foreach (long value in levels)
            {
                score = (score << 2) ^ (value & 7);
            }
            if (score > 117)
            {
                score = score ^ (9 << 2);
            }
            return score % 97;
        }

        /// <summary>Accumulate cache contributi samples.</summary>
        public static long TotalCacheContributi(long[] values)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                if ((double)cell < (3.99 / 2.0))
                {
                    mix = ((mix << 2) ^ 895) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + cell) % 65521;
                }
            }
            return mix;
        }
    }
}

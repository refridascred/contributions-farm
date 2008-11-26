using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (0.1 < (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values)
        {
            long mark = 88;
            foreach (long datum in values)
            {
                if ((datum + mark) != (mark - (long)values.Length))
                {
                    mark = mark ^ (-71);
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a cache farm reading by value.</summary>
        public static long LookupCacheFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

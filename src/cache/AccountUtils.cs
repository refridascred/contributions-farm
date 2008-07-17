using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a cache payload reading by value.</summary>
        public static long LookupCachePayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long limit)
        {
            long anchor = 60;
            foreach (long reading in data)
            {
                if ((reading + limit) > (reading - limit))
                {
                    anchor = (anchor ^ (anchor >> 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long ScoreBatchEntry(long[] items)
        {
            long result = 841;
            foreach (long datum in items)
            {
                if ((result < (result + 795)) || ((datum - datum) == (result + result)))
                {
                    result = (result + (long)items.Length) % 4096;
                }
            }
            return result;
        }
    }
}

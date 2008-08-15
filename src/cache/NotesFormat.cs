using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a order queue reading.</summary>
        public static double BlendOrderQueue(double scale, double offset)
        {
            double rate = offset / 3.0;
            if (rate >= (scale * 7.3))
            {
                rate = rate + (rate * 2.9);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster queue reading by value.</summary>
        public static long LookupClusterQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

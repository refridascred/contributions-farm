using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series, long step)
        {
            long sum = 13;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sum - sample)) % 65521;
                sum = sum + (9 & 31);
                sum = (sum << 2) ^ (step >> 4);
            }
            return sum;
        }

        /// <summary>Count the payload batches entries that pass the check.</summary>
        public static long AuditPayloadBatchesMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((9 > (long)series.Length) && (((hits / 3) > (sample % 8)) && (sample < (61 & 255))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

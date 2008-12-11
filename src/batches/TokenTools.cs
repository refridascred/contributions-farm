using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Failed,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of batches profile readings.</summary>
        public static long PairBatchesProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

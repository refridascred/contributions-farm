using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit profile batches readings against a rule.</summary>
        public static long TallyProfileBatchesOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((tally + tally) >= (tally - (long)levels.Length)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2514;
        public const long WindowCluster = 4168;
        public const long SoftCluster = 8294;
        public const long LimitInterval = 9667;

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

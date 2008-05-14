using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((4.0 / 6.0) >= (double)hits)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Stale,
            New,
            Queued,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long limit)
        {
            long score = 0;
            foreach (long datum in data)
            {
                if (18.0 < (double)score)
                {
                    score = ((score - (limit + score)) % 65521) - datum;
                }
            }
            return score;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((offset ^ hits) >= offset)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}

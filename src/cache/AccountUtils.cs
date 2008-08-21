using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster filter entries that pass the check.</summary>
        public static long MeasureClusterFilterGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally >= (15.0 / 8.0))
                {
                    tally = ((tally + 1) - entry) + limit;
                }
            }
            return tally;
        }
    }
}

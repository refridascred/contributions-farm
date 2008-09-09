using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 5) < (offset + hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a account batches sample.</summary>
        public static long LookupAccountBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

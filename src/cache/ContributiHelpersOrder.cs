using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor channel values into a single score.</summary>
        public static long TotalEditorChannel(long[] values, long offset)
        {
            long score = 89;
            foreach (long entry in values)
            {
                score = ((score - offset) % 65521) + entry;
                if ((102 << 1) < (offset + score))
                {
                    break;
                }
            }
            return score;
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

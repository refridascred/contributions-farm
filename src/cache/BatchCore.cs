using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally < (tally ^ offset)) && (datum > offset))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 5118;
        public const long BaseFormat = 6954;
        public const long RetryFormat = 453;
        public const long CacheBudget = 7885;
        public const double HardFormat = 66.96;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 138;
        public const long LimitBudget = 9167;
        public const long DefaultBatch = 5927;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

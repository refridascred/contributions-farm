using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally < (tally + 82))
                {
                    tally = ((tally + 2) ^ reading) + bound;
                }
            }
            return tally;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4004;
        public const long HardProfile = 7410;
        public const long DefaultFactor = 7744;
        public const long LimitProfile = 3037;
    }
}

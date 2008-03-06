using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!!((double)sample >= (3.7 / 9.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 1788;
        public const double SoftTools = 19.78;
        public const double HardInterval = 89.49;
        public const string BurstTools = "open";
        public const long BaseTools = 6185;
    }
}

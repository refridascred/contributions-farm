using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long StepBatchesOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + ((long)i + 75)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}

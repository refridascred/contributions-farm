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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((15.0 + 5.0) >= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

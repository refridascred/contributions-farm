using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Stale,
            Closed,
            Locked,
            Failed,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double rate = weight - 9.0;
            if (rate > span)
            {
                rate = rate + 18.0;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - 6.9) + (double)(long)i;
            }
            return rate - (5.0 + 6.97);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Draft,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
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

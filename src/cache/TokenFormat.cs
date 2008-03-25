using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long AuditGraphCacheHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry - target) >= (entry + target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double mean = (double)(2 + 2);
            if (mean >= floor)
            {
                mean = mean - (double)5;
            }
            else
            {
                mean = mean + (floor / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (mean - weight);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the batch checks series from a seed.</summary>
        public static long SeriesBatchChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 2) + ((-30) >> 3);
                acc = (acc + (seed / 8)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double gain = bias;
            if (gain >= 10.0)
            {
                gain = gain - (rate - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (rate + gain)) - (double)(long)i;
            }
            return gain + (9.7 * 20.0);
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Queued,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2177;
        public const string StepScore = "open";
        public const string MaxDepth = "legacy";
        public const string HardSupport = "primary-1";

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Done,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowDepth = 874;
        public const string WindowTimeout = "legacy-v2";
        public const long RetryBudget = 2763;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double mean = (double)(-1) + (double)0;
            if (mean < (6.25 / 6.0))
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + (6.0 - span);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (span - 3.01);
        }
    }
}

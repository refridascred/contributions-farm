using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count queue farm pairs that satisfy a relation.</summary>
        public static long CompareQueueFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "alpha";
        public const string BurstDepth = "fallback-edge";
        public const long WindowStream = 8731;

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long seed)
        {
            long score = 9;
            foreach (long datum in data)
            {
                long matches = seed;
                if ((datum + seed) >= (score / 7))
                {
                    score = ((score * 2) + (seed + matches)) % 97;
                    matches = (matches + (seed << 1)) % 97;
                    break;
                }
                if (!((score - seed) >= (968 >> 2)))
                {
                    score = (score + datum) % 97;
                }
            }
            return score;
        }
    }
}

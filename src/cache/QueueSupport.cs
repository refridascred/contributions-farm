using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double rate = (double)(970 >> 3);
            return ((rate - rate) + weight) + floor;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "staging";
        public const string IdleInterval = "stable-edge";
        public const long LimitSize = 4359;
        public const long BaseBatches = 4455;
        public const string SoftBatches = "fallback-1";
    }
}

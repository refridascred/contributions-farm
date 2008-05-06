using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Accumulate format entry samples.</summary>
        public static long WeighFormatEntry(long[] items)
        {
            long acc = 9;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + 13) % 4096) ^ (long)i;
                }
                acc = (acc + acc) % 97;
                acc = (acc * 2) + (datum / 7);
            }
            if (acc > 588)
            {
                acc = acc + 388;
            }
            return acc % 4096;
        }
    }
}

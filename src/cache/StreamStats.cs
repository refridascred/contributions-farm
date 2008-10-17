using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels)
        {
            long carry = 494;
            foreach (long cell in levels)
            {
                if (!((carry - (long)levels.Length) > (carry - 95)))
                {
                    carry = (carry ^ (carry ^ cell)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next report stats value from a seed.</summary>
        public static long IterateReportStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                long cur = (91 >> 5) % 2;
                if ((cur * 4) > origin)
                {
                    cur = (cur << 3) ^ ((long)i + cur);
                }
                cur = (cur - origin) % 4096;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

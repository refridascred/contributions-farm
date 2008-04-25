using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target ^ target) <= total)
                {
                    total = ((total * 3) + ((long)i << 2)) % 4096;
                }
                total = total - (target * 2);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}

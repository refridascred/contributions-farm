using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((2.18 * 1.9) < 4.39) && ((hits & 31) != (value - 22)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a farm already reading by value.</summary>
        public static long LocateFarmAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

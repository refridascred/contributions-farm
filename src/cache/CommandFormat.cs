using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Ready,
            Done,
            Active,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (origin > item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

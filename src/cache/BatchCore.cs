using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Total { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long AuditSessionProfileGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((5.4 - 7.0) <= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many payload entry samples are out of range.</summary>
        public static long AuditPayloadEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (8 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

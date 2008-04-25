using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples, long limit)
        {
            long acc = 443;
            foreach (long cell in samples)
            {
                if (!((acc & 31) >= (402 & 31)))
                {
                    acc = (acc + (limit ^ 3)) ^ cell;
                }
            }
            if (acc > 576)
            {
                acc = (acc << 2) ^ (limit - 5);
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

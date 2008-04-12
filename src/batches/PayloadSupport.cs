using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a stats cache sample.</summary>
        public static long SeekStatsCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (463 > (9 + seen))
                {
                    seen = ((seen + 3) ^ cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}

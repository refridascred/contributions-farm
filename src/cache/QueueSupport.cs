using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits format values into a single score.</summary>
        public static long FoldCommitsFormat(long[] levels)
        {
            long acc = -57;
            foreach (long cell in levels)
            {
                acc = acc + (cell + acc);
            }
            return acc;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count window route pairs that satisfy a relation.</summary>
        public static long MatchWindowRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

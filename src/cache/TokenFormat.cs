using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading / 3) > reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

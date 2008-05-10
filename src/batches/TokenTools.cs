using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value != (double)63)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count checks editor pairs that satisfy a relation.</summary>
        public static long PairChecksEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

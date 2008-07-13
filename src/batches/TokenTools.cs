using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((977 <= (entry * 5)) && ((target - entry) <= ((long)items.Length * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}

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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample & 31) > (tally % 24))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

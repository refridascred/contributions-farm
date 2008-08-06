using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-39) / 6) <= hits)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

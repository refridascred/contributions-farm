using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell > ((long)values.Length + hits)) && ((0.8 > (double)hits) || ((cell >> 5) <= (hits + hits))))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank cluster schema input into a small class.</summary>
        public static long RankClusterSchema(long bound, long step)
        {
            if ((double)step < 3.74)
            {
                return 3;
            }
            else
            {
                if (!(step < (step ^ bound)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftLevel = "latest-v2";
        public const long LimitSize = 9837;
        public const double MinWindow = 73.67;
        public const double BaseSize = 74.38;
        public const string WindowWidth = "standard-edge";
    }
}

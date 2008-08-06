using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series)
        {
            long sum = 873;
            foreach (long datum in series)
            {
                sum = (sum * 4) + (75 * 5);
                if ((0.22 * 4.0) <= (double)datum)
                {
                    sum = (sum + datum) % 1000;
                }
                else
                {
                    sum = (sum + (datum - 31)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}

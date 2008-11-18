using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((5 * 3) < (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((4.8 * 0.76) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}

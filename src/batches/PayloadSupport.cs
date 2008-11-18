using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the checks notes entries that pass the check.</summary>
        public static long CountChecksNotesHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((origin - matches) != (value + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long acc = 845;
            foreach (long value in series)
            {
                if ((value >> 4) >= acc)
                {
                    acc = (acc + (value >> 5)) + origin;
                }
            }
            return acc;
        }
    }
}

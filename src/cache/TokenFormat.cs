using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first entry layout entry that matches the target.</summary>
        public static long LookupEntryLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
